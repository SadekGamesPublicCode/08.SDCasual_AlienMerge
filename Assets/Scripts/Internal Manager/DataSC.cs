using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSC : MonoBehaviour
{
    [HideInInspector] PlayerInforSC infor;
    public string deviceID;
    public bool isFirstPlay;

    [SerializeField] SaveSystem saveSys;

    //Shared variables
    [HideInInspector] public int pSFX, pTheme;

    //Player's data variables

    [HideInInspector] public int pGems, pCoin; //actual in-game currency to buy things


    //Patrol & Achievemnt
    [HideInInspector] public int pAllowClaimDaily, pDailyStreak;
    [HideInInspector] public string pLastDailyClaim;

    //Morpinos Evolution Exclusive Vars
    [HideInInspector] public int pTotalScore; //total Morpinos was born, count on Creepling as base units
    [HideInInspector] public int pMorpinosOrder;

    [HideInInspector] public int pCreep0, pCreep1, pCreep2, pCreep3, pCreep4, pCreep5, pCreep6, pCreep7, pCreep8, pCreep9;
    [HideInInspector] public int pAra0, pAra1, pAra2, pAra3, pAra4;
    [HideInInspector] public int pTerror0, pTerror1, pTerror2, pTerror3, pTerror4;
    [HideInInspector] public int pDraki0, pDraki1, pDraki2;
    [HideInInspector] public int pMega0, pMega1, pMega2, pMega3;
    [HideInInspector] public int pPrima0, pPrima1, pPrima2, pPrima3;
    [HideInInspector] public int pTerra0, pTerra1, pTerra2;
    [HideInInspector] public int pGigan0, pGigan1, pGigan2;
    [HideInInspector] public int pStructHive, pStructEssensePool, pSructMoneyMine;

    [HideInInspector] public int pEggBonusRate, pEggBonusAmount, pCoinBonusVaue;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        SettingStart();
    }
    public void Start()
    {

    }

    #region Local Handle
    private void SettingStart()
    {
        deviceID = SystemInfo.deviceUniqueIdentifier;
        if (CheckFirstPlay() == true)
        {
            SetNewPlayer();
        }
        else if (CheckFirstPlay() == false)
        {
            LoadOldPlayer();
        }
        ///infor = GameObject.Find("GenMN").GetComponent<PlayerInforSC>();
    }

    #endregion

    #region Player Data Handle
    private void SetNewPlayer()
    {
        Debug.Log("in new layer");
        PlayerPrefs.SetInt("HasPlayed", 1);

        PlayerPrefs.SetInt("Highscore", 0); //For total overview, leaderboard
        PlayerPrefs.SetInt("Totalscore", 0); //Actual player in-game currency
        PlayerPrefs.SetInt("TotalGems", 0); //Player's PIA currency
        PlayerPrefs.SetInt("TotalCoin", 0);

        PlayerPrefs.SetInt("soundState", 1);
        PlayerPrefs.SetInt("sfxState", 1);

        //Patrol Reward
        PlayerPrefs.SetInt("AllowClaimDaily", 0);
        PlayerPrefs.SetString("LastPatrolDailyTime", "");
        PlayerPrefs.SetInt("PatrolDailyStreak", 0);

        //Gameplay
        PlayerPrefs.SetInt("BonusAmount", 0);
        PlayerPrefs.SetInt("BonusRate", 0);
        PlayerPrefs.SetInt("BonusCointValue", 0);

        Invoke("LoadOldPlayer", 3f); //De tam thoi
    }
    private void LoadOldPlayer()
    {
        pTotalScore = PlayerPrefs.GetInt("Totalscore");
        pGems = PlayerPrefs.GetInt("TotalGems");
        pCoin = PlayerPrefs.GetInt("TotalCoin");
        pTheme = PlayerPrefs.GetInt("soundState");
        pSFX = PlayerPrefs.GetInt("sfxState");

        //Patrol Reward
        pLastDailyClaim = PlayerPrefs.GetString("LastPatrolDailyTime");
        pAllowClaimDaily = PlayerPrefs.GetInt("AllowClaimDaily"); //0 = allow, 1 = deny
        pDailyStreak = PlayerPrefs.GetInt("PatrolDailyStreak");

        //Gameplay
        pEggBonusAmount = PlayerPrefs.GetInt("BonusAmount");
        pEggBonusRate = PlayerPrefs.GetInt("BonusRate");
        pCoinBonusVaue = PlayerPrefs.GetInt("BonusCointValue");

        InvokeRepeating(nameof(AutoSaveMorpinos), 60f, 60f);
    }
    public void OnLoadMorpinos()
    {
        MorpinosData dataLoad = saveSys.Load();

        pCreep0 = dataLoad.creeplingOnScreen[0];
        pCreep1 = dataLoad.creeplingOnScreen[1];
        pCreep2 = dataLoad.creeplingOnScreen[2];
        pCreep3 = dataLoad.creeplingOnScreen[3];
        pCreep4 = dataLoad.creeplingOnScreen[4];
        pCreep5 = dataLoad.creeplingOnScreen[5];
        pCreep6 = dataLoad.creeplingOnScreen[6];
        pCreep7 = dataLoad.creeplingOnScreen[7];
        pCreep8 = dataLoad.creeplingOnScreen[8];
        pCreep9 = dataLoad.creeplingOnScreen[9];
        pAra0 = dataLoad.araOnscreen[0];
        pAra1 = dataLoad.araOnscreen[1];
        pAra2 = dataLoad.araOnscreen[2];
        pAra3 = dataLoad.araOnscreen[3];
        pAra4 = dataLoad.araOnscreen[4];
        pTerror0 = dataLoad.terrorOnScreen[0];
        pTerror1 = dataLoad.terrorOnScreen[1];
        pTerror2 = dataLoad.terrorOnScreen[2];
        pTerror3 = dataLoad.terrorOnScreen[3];
        pTerror4 = dataLoad.terrorOnScreen[4];
        pDraki0 = dataLoad.drakiOnScreen[0];
        pDraki1 = dataLoad.drakiOnScreen[1];
        pDraki2 = dataLoad.drakiOnScreen[2];
        pMega0 = dataLoad.megaOnScreen[0];
        pMega1 = dataLoad.megaOnScreen[1];
        pMega2 = dataLoad.megaOnScreen[2];
        pMega3 = dataLoad.megaOnScreen[3];
        pPrima0 = dataLoad.megaOnScreen[0];
        pPrima1 = dataLoad.megaOnScreen[1];
        pPrima2 = dataLoad.megaOnScreen[2];
        pPrima3 = dataLoad.megaOnScreen[3];
        pGigan0 = dataLoad.gigantOnScreen[0];
        pGigan1 =  dataLoad.gigantOnScreen[1];
        pGigan2 = dataLoad.gigantOnScreen[2];
        pTerra0 = dataLoad.terraOnScreen[0];
        pTerra1 = dataLoad.terraOnScreen[1];
        pTerra2 = dataLoad.terraOnScreen[2];
    }
    public void DataDelete()
    {
        PlayerPrefs.DeleteAll();
        OnResetJSON();
        SetNewPlayer();
        //infor.GetPlayerData();
    }
    public void UploadPlayerData()
    {
        //Sent core data to Server
    }
    private void OnResetJSON() { saveSys.OnReset(); }
    #endregion

    #region Data Update

    //Economic
    public void UpdateTotalScore(int currencyToPlus)
    {
        int tempTotalScore;
        tempTotalScore = pTotalScore + currencyToPlus;
        PlayerPrefs.SetInt("Totalscore", tempTotalScore);
        pTotalScore = PlayerPrefs.GetInt("Totalscore");

        print("pTotalScore in data = " + pTotalScore);
    }
    public void UpdateTotalGem(int gems)
    {
        PlayerPrefs.SetInt("TotalGems", gems);
        pGems = PlayerPrefs.GetInt("TotalGems");
    }
    public void UpdateTotalCoin(int coin)
    {
        PlayerPrefs.SetInt("TotalCoin", coin);
        pCoin = PlayerPrefs.GetInt("TotalCoin");
    }

    //Sound
    public void UpdateSFXState(int sfxState)
    {
        PlayerPrefs.SetInt("sfxState", sfxState);
        pSFX = PlayerPrefs.GetInt("sfxState");
    }
    public void UpdateThemeState(int thameState)
    {
        PlayerPrefs.SetInt("soundState", thameState);
        pTheme = PlayerPrefs.GetInt("soundState");
    }

    //Patrol Reward
    public void UpdatePatrolDailyReward(string lastPatrolDaily)
    {
        PlayerPrefs.SetString("LastPatrolDailyTime", lastPatrolDaily);
        pLastDailyClaim = PlayerPrefs.GetString("LastPatrolDailyTime");
    }
    public void UpdateAllowClaimDaily(int state)
    {
        PlayerPrefs.SetInt("AllowClaimDaily", state);
        pAllowClaimDaily = PlayerPrefs.GetInt("AllowClaimDaily");
    }
    public void UpdateStreak(int typeStreak, int value)
    {
        PlayerPrefs.SetInt("PatrolDailyStreak", value);
        pDailyStreak = PlayerPrefs.GetInt("PatrolDailyStreak");
    }

    //Gameplay
    public void UpdateBonusSpawnRate(int amount)
    {
        PlayerPrefs.SetInt("BonusRate", 0);
        pEggBonusRate = PlayerPrefs.GetInt("BonusRate");
    }
    public void UpdateBonusSpawnAmount(int amount)
    {
        PlayerPrefs.SetInt("BonusAmount", 0);
        pEggBonusAmount = PlayerPrefs.GetInt("BonusAmount");
    }
    public void UpdateBonusCoinValue(int amount)
    {
        PlayerPrefs.SetInt("BonusCointValue", 0);
        pCoinBonusVaue = PlayerPrefs.GetInt("BonusCointValue");
    }

    #endregion

    #region Update Morpinos
    public void OnUpdateCreepling(int breedOrder)
    {
        switch (breedOrder)
        {
            case 0:
                pCreep0++;
                break;
            case 1:
                pCreep0 -= 2;
                pCreep1++;
                break;
            case 2:
                pCreep1 -= 2;
                pCreep2++;
                break;
            case 3:
                pCreep2 -= 2;
                pCreep3++;
                break;
            case 4:
                pCreep3 -= 2;
                pCreep4++;
                break;
            case 5:
                pCreep4 -= 2;
                pCreep5++;
                break;
            case 6:
                pCreep5 -= 2;
                pCreep6++;
                break;
            case 7:
                pCreep6 -= 2;
                pCreep7++;
                break;
            case 8:
                pCreep7 -= 2;
                pCreep8++;
                break;
            case 9:
                pCreep8 -= 2;
                pCreep9++;
                break;
            case 10:
                pCreep9 -= 2;
                break;
        }
    }
    public void OnUpdateDataTier2(int breedOrder, int breedSubOrder)
    {
        if (breedOrder == 0)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pAra0++;
                    break;
                case 1:
                    pAra0 -= 2;
                    pAra1++;
                    break;
                case 2:
                    pAra1 -= 2;
                    pAra2++;
                    break;
                case 3:
                    pAra2 -= 2;
                    pAra3++;
                    break;
                case 4:
                    pAra3 -= 2;
                    pAra4++;
                    break;
            }
        }
        else if (breedOrder == 1)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pTerror0++;
                    break;
                case 1:
                    pTerror0 -= 2;
                    pTerror1++;
                    break;
                case 2:
                    pTerror1 -= 2;
                    pTerror2++;
                    break;
                case 3:
                    pTerror2 -= 2;
                    pTerror3++;
                    break;
                case 4:
                    pTerror3 -= 2;
                    pTerror4++;
                    break;
            }
        }
        else if (breedOrder == 2)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pDraki0++;
                    break;
                case 1:
                    pDraki0 -= 2;
                    pDraki1++;
                    break;
                case 2:
                    pDraki1 -= 2;
                    pDraki2++;
                    break;
            }
        }
    }
    public void OnUpdateDataTier3(int breedOrder, int breedSubOrder)
    {
        if (breedOrder == 0)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pMega0++;
                    break;
                case 1:
                    pMega0 -= 2;
                    pMega1++;
                    break;
                case 2:
                    pMega1 -= 2;
                    pMega2++;
                    break;
                case 3:
                    pMega2 -= 2;
                    pMega3++;
                    break;
            }
        }
        else if (breedOrder == 1)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pPrima0++;
                    break;
                case 1:
                    pPrima0 -= 2;
                    pPrima1++;
                    break;
                case 2:
                    pPrima1 -= 2;
                    pPrima2++;
                    break;
                case 3:
                    pPrima2 -= 2;
                    pPrima3++;
                    break;
            }
        }
    }
    public void OnUpdateDataTier4(int breedOrder, int breedSubOrder)
    {
        if (breedOrder == 0)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pGigan0++;
                    break;
                case 1:
                    pGigan0 -= 2;
                    pGigan1++;
                    break;
                case 2:
                    pGigan1 -= 2;
                    pGigan2++;
                    break;
            }
        }
        else if (breedOrder == 1)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pTerra0++;
                    break;
                case 1:
                    pTerra0 -= 2;
                    pTerra1++;
                    break;
                case 2:
                    pTerra1 -= 2;
                    pTerra2++;
                    break;
            }
        }
    }
    #endregion

    #region Checking Zone
    private bool CheckFirstPlay()
    {
        if (PlayerPrefs.GetInt("HasPlayed") == 1) return isFirstPlay = false;
        else return true;
    }
    #endregion

    #region Save to JSON
    public void AutoSaveMorpinos()
    {
        SaveCreep();
        SaveAra();
        SaveTerror();
        SavePrima();
        SaveMega();
        SaveGigant();
        SaveTerra();
        SaveDraki();
    }
    private void SaveCreep()
    {
        int[] a = { pCreep0, pCreep1, pCreep2, pCreep3, pCreep4, pCreep5, pCreep6, pCreep7, pCreep8, pCreep9 };
        saveSys.OnSaveCreep(a);
    }
    private void SaveAra() 
    {
        int[] a = { pAra0, pAra1, pAra2, pAra3, pAra4 };
        saveSys.OnSaveAra(a);
    }
    private void SaveTerror()
    {
        int[] a = { pTerror0, pTerror1, pTerror2, pTerror3, pTerror4 };
        saveSys.OnSaveTerror(a);
    }
    private void SaveMega()
    {
        int[] a = {pMega0, pMega1, pMega2, pMega3 };
        saveSys.OnSaveMega(a);
    }
    private void SavePrima()
    {
        int[] a = { pPrima0, pPrima1, pPrima2, pPrima3 };
        saveSys.OnSavePrima(a);
    }
    private void SaveGigant()
    {
        int[] a = { pGigan0, pGigan1, pGigan2 };
        saveSys.OnSaveGigant(a);
    }
    private void SaveTerra()
    {
        int[] a = { pTerra0, pTerra1, pTerra2 };
        saveSys.OnSaveTerra(a);
    }
    private void SaveDraki()
    {
        int[] a = { pDraki0, pDraki1, pDraki2 };
        saveSys.OnSaveDraki(a);
    }
    #endregion
}
