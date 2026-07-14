using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSC : MonoBehaviour
{
    [HideInInspector] DataSC dataCtr;
    int priceBoostRate, priceAmount, priceBoostCoin, priceEgg01, priceEgg02, priceEgg03, priceEg00;
    int curPlayerCoin, curPlayerGems;
    void Start()
    {
        dataCtr = GameObject.Find("GenMN").GetComponent<DataSC>();
        priceBoostRate = 100;
        priceAmount = 100;
        priceBoostCoin = 100;

        curPlayerCoin = dataCtr.pCoin;
        curPlayerGems = dataCtr.pGems;
    }

    public void OnBuyBoostAmount()
    {
        if(IsAllowBuy(curPlayerCoin, priceAmount))
        {
            //Allow Boost amoun
            HandleBuy(priceAmount, curPlayerCoin);
            dataCtr.UpdateBonusSpawnAmount(300);
        }
    }
    public void OnBuyBoostRate()
    {
        if (IsAllowBuy(curPlayerCoin, priceBoostRate))
        {
            //Allow Boost amoun
            HandleBuy(priceBoostRate, curPlayerCoin);
            dataCtr.UpdateBonusSpawnRate(300);
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
                    HandleBuy(priceEgg01, curPlayerCoin);
                }
                break;
            case 1:
                //Ara + Terror + Draki
                if (IsAllowBuy(curPlayerCoin, priceEgg01))
                {
                    //Allow Boost amoun
                    HandleBuy(priceEgg01, curPlayerCoin);
                }
                break;
            case 2:
                //Prima + Mega
                if (IsAllowBuy(curPlayerCoin, priceEgg02))
                {
                    //Allow Boost amoun
                    HandleBuy(priceEgg02, curPlayerCoin);
                }
                break;
            case 3:
                //Terra + Gigant
                if (IsAllowBuy(curPlayerCoin, priceEgg03))
                {
                    //Allow Boost amoun
                    HandleBuy(priceEgg03, curPlayerCoin);
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
}
