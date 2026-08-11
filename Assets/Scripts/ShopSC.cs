using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSC : MonoBehaviour
{
    [HideInInspector] DataSC dataCtr;
    [SerializeField] OutMoneySC outMoneyPnl;
    [SerializeField] MenuMN menuCtr;
    [SerializeField] MergeSC meregeMN;
    int priceBoostRate, priceAmount, priceBoostCoin, priceEgg01, priceEgg02, priceEgg03, priceEg00;
    int curItemToBuy;
    int curPlayerCoin, curPlayerGems;
    void Start()
    {
        dataCtr = GameObject.Find("GenMN").GetComponent<DataSC>();
        priceBoostRate = 100;
        priceAmount = 100;
        priceBoostCoin = 100;
        priceEg00 = 10;
        priceEgg01 = 100;
        priceEgg02 = 1000;
        priceEgg03 = 10000;

        curPlayerCoin = dataCtr.pCoin;
        curPlayerGems = dataCtr.pGems;
        curItemToBuy = -1;
    }

    public void OnBuyBoostAmount()
    {
        if(IsAllowBuy(curPlayerCoin, priceAmount))
        {
            //Allow Boost amoun
            HandleBuy(priceAmount, curPlayerCoin);
            dataCtr.UpdateBonusSpawnAmount(300);
        }else
        {
            curItemToBuy = 0;
            OnOutOfMoney();
        }
    }
    public void OnBuyBoostRate()
    {
        if (IsAllowBuy(curPlayerCoin, priceBoostRate))
        {
            //Allow Boost amoun
            HandleBuy(priceBoostRate, curPlayerCoin);
            dataCtr.UpdateBonusSpawnRate(300);
        }else
        {
            curItemToBuy = 1;
            OnOutOfMoney();
        }
    }
    public void OnBuyBoostCoin()
    {
        if (IsAllowBuy(curPlayerCoin, priceBoostCoin))
        {
            //Allow Boost amoun
            HandleBuy(priceBoostCoin, curPlayerCoin);
            dataCtr.UpdateBonusCoinValue(300);
        }
        else
        {
            curItemToBuy = 2;
            OnOutOfMoney();
        }
    }
    public void OnBuyEgg(int eggOrder)
    {
        switch (eggOrder)
        {
            case 0:
                //Creep
                if (IsAllowBuy(curPlayerCoin, priceEg00))
                {
                    //Allow Boost amoun
                    HandleBuy(priceEg00, curPlayerCoin);
                    meregeMN.OnSpawnEggFromShop(0);
                }
                else
                {
                    curItemToBuy = 3;
                    OnOutOfMoney();
                }
                break;
            case 1:
                //Ara + Terror + Draki
                if (IsAllowBuy(curPlayerCoin, priceEgg01))
                {
                    //Allow Boost amoun
                    curItemToBuy = 4;
                    HandleBuy(priceEgg01, curPlayerCoin);
                    meregeMN.OnSpawnEggFromShop(1);
                }
                else
                {
                    curItemToBuy = 4;
                    OnOutOfMoney();
                }
                break;
            case 2:
                //Prima + Mega
                if (IsAllowBuy(curPlayerCoin, priceEgg02))
                {
                    //Allow Boost amoun
                    HandleBuy(priceEgg02, curPlayerCoin);
                    meregeMN.OnSpawnEggFromShop(2);
                }
                else
                {
                    curItemToBuy = 5;
                    OnOutOfMoney();
                }
                break;
            case 3:
                //Terra + Gigant
                if (IsAllowBuy(curPlayerCoin, priceEgg03))
                {
                    HandleBuy(priceEgg03, curPlayerCoin);
                    meregeMN.OnSpawnEggFromShop(3);
                }
                else
                {
                    curItemToBuy = 6;
                    OnOutOfMoney();
                }
                break;
        }
    }
    private bool IsAllowBuy(int curMoney, int itemPrice)
    {
        if(curMoney >= itemPrice)
        {
            return true;
        }else return false;
    }
    private void HandleBuy(int price, int pMoneyAmount)
    {
        curPlayerCoin = pMoneyAmount - price;
        dataCtr.UpdateTotalCoin(curPlayerCoin);
        curPlayerCoin = dataCtr.pCoin;
    }
    private void OnOutOfMoney()
    {
        outMoneyPnl.gameObject.SetActive(true);
    }
    public void BuyByAds()
    {
        menuCtr.OnShowAdsReward();
        OnHandleBuyEggDone(curItemToBuy);
        curItemToBuy = -1;
    }
    private void OnHandleBuyEggDone(int eggToSpawn)
    {
        switch (curItemToBuy)
        {
            case 0:
                dataCtr.UpdateBonusSpawnAmount(300);
                break;
            case 1:
                dataCtr.UpdateBonusSpawnRate(300);
                break;
            case 2:
                dataCtr.UpdateBonusCoinValue(300);
                break;
            case 3:
                meregeMN.OnSpawnEggFromShop(0);
                break;
            case 4:
                meregeMN.OnSpawnEggFromShop(1);
                break;
            case 5:
                meregeMN.OnSpawnEggFromShop(2);
                break;
            case 6:
                meregeMN.OnSpawnEggFromShop(3);
                break;
        }
    }

}
