using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSC : MonoBehaviour
{
    [HideInInspector] GenControlSC genCtr;
    [HideInInspector] DataSC dataSC;

    [SerializeField] List<GameObject> creeplingToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> araToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> terrorToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> drakiToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> megaToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> primaToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> terraToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> gigantToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> prefEggCreep = new List<GameObject>();
    //
    [SerializeField] GameObject essensePool;
    private Vector3 spawnPos;
    int pairedCount, curPower;
    float spawnRateDelay;
    void Start()
    {
        spawnRateDelay = 5f;
        genCtr = GameObject.Find("GenMN").GetComponent<GenControlSC>();
        dataSC = GameObject.Find("GenMN").GetComponent<DataSC>();
        InvokeRepeating(nameof(SpawnEggCreepling), 0f, spawnRateDelay);
        pairedCount = 0;

        SpawnOnInit();
    }
    private void SpawnEggCreepling()
    {
        int tempPosX, tempPosY;
        tempPosX = Random.Range(-3, 3);
        tempPosY = Random.Range(-5, 5);
        spawnPos = new Vector3(tempPosX, tempPosY, 0);

        print("countdownSpawnAmount = " + genCtr.isBoostAmount);

        if (genCtr.isBoostRate == false && genCtr.isBoostAmount == true)
        {
            print("in Rate false, Amount true");
            //Boost amount + nonRate
            Instantiate((prefEggCreep[0]), new Vector3(spawnPos.x - 0.25f,spawnPos.y, 0) , Quaternion.identity);
            Instantiate((prefEggCreep[0]), new Vector3(spawnPos.x + 0.25f, spawnPos.y, 0), Quaternion.identity);
        }
        else if (genCtr.isBoostRate == true && genCtr.isBoostAmount == false)
        {
            print("in Rate true, Amount fales");

            //Boost rate + nonAmount
            if (spawnRateDelay != 2f) spawnRateDelay = 2f;
            Instantiate((prefEggCreep[0]), spawnPos, Quaternion.identity);
        }
        else if (genCtr.isBoostRate == true && genCtr.isBoostAmount == true)
        {
            //Boost amount + boost rate
            print("in Rate true, Amount true");

            if (spawnRateDelay != 2f) spawnRateDelay = 2f;
            Instantiate((prefEggCreep[0]), new Vector3(spawnPos.x - 0.25f, spawnPos.y, 0), Quaternion.identity);
            Instantiate((prefEggCreep[0]), new Vector3(spawnPos.x + 0.25f, spawnPos.y, 0), Quaternion.identity);
        }
        else if(genCtr.isBoostRate == false && genCtr.isBoostAmount == false)
        {
            //Non boost
            print("in Rate false, Amount false");

            if (spawnRateDelay == 2f) spawnRateDelay = 5f;
            Instantiate((prefEggCreep[0]), spawnPos, Quaternion.identity);
        }
    }
    private void SpawnOnInit()
    {
        if(dataSC.pCreep0 != 0) { OnSpawnMorpinosInit(0, 0, dataSC.pCreep0); }
        if (dataSC.pCreep1 != 0) { OnSpawnMorpinosInit(0, 1, dataSC.pCreep1); }
        if (dataSC.pCreep2 != 0) { OnSpawnMorpinosInit(0, 2, dataSC.pCreep2); }
        if (dataSC.pCreep3 != 0) { OnSpawnMorpinosInit(0, 3, dataSC.pCreep3); }
        if (dataSC.pCreep4 != 0) { OnSpawnMorpinosInit(0, 4, dataSC.pCreep4); }
        if (dataSC.pCreep5 != 0) { OnSpawnMorpinosInit(0, 5, dataSC.pCreep5); }
        if (dataSC.pCreep6 != 0) { OnSpawnMorpinosInit(0, 6, dataSC.pCreep6); }
        if (dataSC.pCreep7 != 0) { OnSpawnMorpinosInit(0, 7, dataSC.pCreep7); }
        if (dataSC.pCreep8 != 0) { OnSpawnMorpinosInit(0, 8, dataSC.pCreep8); }
        if (dataSC.pCreep9 != 0) { OnSpawnMorpinosInit(0, 9, dataSC.pCreep9); }

        if (dataSC.pAra0 != 0) { OnSpawnMorpinosInit(1, 0, dataSC.pAra0); }
        if (dataSC.pAra1 != 0) { OnSpawnMorpinosInit(1, 1, dataSC.pAra1); }
        if (dataSC.pAra2 != 0) { OnSpawnMorpinosInit(1, 2, dataSC.pAra2); }
        if (dataSC.pAra3 != 0) { OnSpawnMorpinosInit(1, 3, dataSC.pAra3); }
        if (dataSC.pAra4 != 0) { OnSpawnMorpinosInit(1, 4, dataSC.pAra4); }

        if (dataSC.pTerror0 != 0) { OnSpawnMorpinosInit(2, 0, dataSC.pTerror0); }
        if (dataSC.pTerror1 != 0) { OnSpawnMorpinosInit(2, 1, dataSC.pTerror1); }
        if (dataSC.pTerror2 != 0) { OnSpawnMorpinosInit(2, 2, dataSC.pTerror2); }
        if (dataSC.pTerror3 != 0) { OnSpawnMorpinosInit(2, 3, dataSC.pTerror3); }
        if (dataSC.pTerror4 != 0) { OnSpawnMorpinosInit(2, 4, dataSC.pTerror4); }

        if (dataSC.pDraki0 != 0) { OnSpawnMorpinosInit(3, 0, dataSC.pDraki0); }
        if (dataSC.pDraki1 != 0) { OnSpawnMorpinosInit(3, 1, dataSC.pDraki1); }
        if (dataSC.pDraki2 != 0) { OnSpawnMorpinosInit(3, 2, dataSC.pDraki2); }

        if (dataSC.pMega0 != 0) { OnSpawnMorpinosInit(4, 0, dataSC.pMega0); }
        if (dataSC.pMega1 != 0) { OnSpawnMorpinosInit(4, 1, dataSC.pMega1); }
        if (dataSC.pMega2 != 0) { OnSpawnMorpinosInit(4, 2, dataSC.pMega2); }
        if (dataSC.pMega3 != 0) { OnSpawnMorpinosInit(4, 3, dataSC.pMega3); }

        if (dataSC.pPrima0 != 0) { OnSpawnMorpinosInit(5, 0, dataSC.pPrima0); }
        if (dataSC.pPrima1 != 0) { OnSpawnMorpinosInit(5, 1, dataSC.pPrima1); }
        if (dataSC.pPrima2 != 0) { OnSpawnMorpinosInit(5, 2, dataSC.pPrima2); }
        if (dataSC.pPrima3 != 0) { OnSpawnMorpinosInit(5, 3, dataSC.pPrima3); }

        if (dataSC.pGigan0 != 0) { OnSpawnMorpinosInit(6, 0, dataSC.pGigan0); }
        if (dataSC.pGigan0 != 0) { OnSpawnMorpinosInit(6, 1, dataSC.pGigan1); }
        if (dataSC.pGigan0 != 0) { OnSpawnMorpinosInit(6, 2, dataSC.pGigan2); }

        if (dataSC.pTerra0 != 0) { OnSpawnMorpinosInit(7, 0, dataSC.pTerra0); }
        if (dataSC.pTerra1 != 0) { OnSpawnMorpinosInit(7, 1, dataSC.pTerra1); }
        if (dataSC.pTerra2 != 0) { OnSpawnMorpinosInit(7, 2, dataSC.pTerra2); }
    }
    private void OnSpawnMorpinosInit(int breedToSpawn, int subBreedToSpawn, int amountToSpawn)
    {
        if (breedToSpawn == 0)
        {
            //Creepling
            for (int i = 0; i < amountToSpawn; i++)
            {
                Instantiate(creeplingToSpawn[subBreedToSpawn], Vector3.zero, Quaternion.identity);
            }
        }else if(breedToSpawn == 1)
        {
            //Ara
            for (int i = 0; i < amountToSpawn; i++)
            {
                Instantiate(araToSpawn[subBreedToSpawn], Vector3.zero, Quaternion.identity);
            }
        }
        else if(breedToSpawn == 2)
        {
            //Terror
            for (int i = 0; i < amountToSpawn; i++)
            {
                Instantiate(terrorToSpawn[subBreedToSpawn], Vector3.zero, Quaternion.identity);
            }
        }
        else if(breedToSpawn == 3)
        {
            //Draki
            for (int i = 0; i < amountToSpawn; i++)
            {
                Instantiate(drakiToSpawn[subBreedToSpawn], Vector3.zero, Quaternion.identity);
            }
        }
        else if(breedToSpawn == 4)
        {
            //Mega
            for (int i = 0; i < amountToSpawn; i++)
            {
                Instantiate(megaToSpawn[subBreedToSpawn], Vector3.zero, Quaternion.identity);
            }
        }
        else if(breedToSpawn == 5)
        {
            //Prima
            for (int i = 0; i < amountToSpawn; i++)
            {
                Instantiate(primaToSpawn[subBreedToSpawn], Vector3.zero, Quaternion.identity);
            }
        }
        else if(breedToSpawn == 6)
        {
            //Gigant
            for (int i = 0; i < amountToSpawn; i++)
            {
                Instantiate(gigantToSpawn[subBreedToSpawn], Vector3.zero, Quaternion.identity);
            }
        }
        else if (breedToSpawn == 7)
        {
            //Terra
            for (int i = 0; i < amountToSpawn; i++)
            {
                Instantiate(terraToSpawn[subBreedToSpawn], Vector3.zero, Quaternion.identity);
            }
        }

    }
    public void OnCallSpawn(int breedOrder, int objectToSpawn, float posX, float posY)
    {
        pairedCount++;
        Vector3 spawnPos = new Vector3(posX, posY, 0);
        if(pairedCount >= 2)
        {
            pairedCount = 0;
            switch (breedOrder)
            {
                case 0:
                    //Creepling
                    if(objectToSpawn >= 9)
                    {
                        Instantiate(prefEggCreep[1], spawnPos, Quaternion.identity);
                    }
                    else 
                    {
                        Instantiate(creeplingToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity);
                        dataSC.OnUpdateCreepling(objectToSpawn+1);
                    }
                    break;
                case 1:
                    //Ara
                    if (objectToSpawn >= 4)
                    {
                        Instantiate(prefEggCreep[2], spawnPos, Quaternion.identity);
                    }else
                    {
                        Instantiate(araToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity);
                        dataSC.OnUpdateDataTier2(breedOrder, objectToSpawn+1);
                    }         
                    break;
                case 2:
                    //Terroling
                    if (objectToSpawn >= 4)
                    {
                        Instantiate(prefEggCreep[2], spawnPos, Quaternion.identity);
                    }else
                    {
                        Instantiate(terrorToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity);
                        dataSC.OnUpdateDataTier2(breedOrder, objectToSpawn+1);
                    }
                    break;
                case 3:
                    //Drakinos
                    break;
                case 4:
                    if (objectToSpawn >= 3)
                    {
                        Instantiate(prefEggCreep[3], spawnPos, Quaternion.identity);
                    }else
                    {
                        Instantiate(megaToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity);
                        dataSC.OnUpdateDataTier3(breedOrder, objectToSpawn+1);
                    }
                    break;
                case 5:
                    if (objectToSpawn >= 3)
                    {
                        Instantiate(prefEggCreep[3], spawnPos, Quaternion.identity);
                    }else
                    {
                        Instantiate(primaToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity);
                        dataSC.OnUpdateDataTier3(breedOrder, objectToSpawn+1);
                    }
                    break;
                case 6:
                    if (objectToSpawn >= 2)
                    {
                        Instantiate(essensePool, spawnPos, Quaternion.identity);
                    }else
                    {
                        Instantiate(terraToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity);
                        dataSC.OnUpdateDataTier4(breedOrder, objectToSpawn+1);
                    }
                    break;
                case 7:
                    if (objectToSpawn >= 2)
                    {
                        Instantiate(essensePool, spawnPos, Quaternion.identity);
                    }else
                    {
                        Instantiate(gigantToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity);
                        dataSC.OnUpdateDataTier4(breedOrder, objectToSpawn+1);
                    }
                    break;
            }
        }
    }
    public void OnCountCurrentPower()
    {
        genCtr.IncreaseCurPower();
    }
}
