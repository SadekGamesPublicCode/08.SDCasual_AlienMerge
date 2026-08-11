using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Egg_CreepSC : MonoBehaviour
{
    [HideInInspector] MergeSC mergCtr;
    [HideInInspector] DataSC dataCtr;
    int countToHatch;
    [SerializeField] int eggStraitTier;
    [SerializeField] GameObject creepling, arachiling, terrorling, megarhinos, primanos, gigantinos, terranos, drakinos;
    [SerializeField] Image hatchProgress;

    [HideInInspector] bool isCorrectDNA;
    [HideInInspector] int eggStraitDNA;
    void Start()
    {
        mergCtr = GameObject.Find("MergeMN").GetComponent<MergeSC>();
        dataCtr = GameObject.Find("GenMN").GetComponent<DataSC>();
        countToHatch = 0;
        hatchProgress.fillAmount = 0;
        isCorrectDNA = false;
    }
    private void OnMouseDown()
    {
        print("on mouse down");
        countToHatch++;
        if(eggStraitTier == 0)
        {
            //Creepling
            hatchProgress.fillAmount += 0.2f;
            if (countToHatch >= 5)
            {
                SpawnCreepling();
            }
        }else if(eggStraitTier == 1)
        {
            hatchProgress.fillAmount += 0.2f;
            if(countToHatch >= 5)
            {
                int tempRandToHatch;
                tempRandToHatch = Random.Range(0, 100);
                if(tempRandToHatch >= 50)
                {
                    SpawnAra();
                } else if(tempRandToHatch < 50)
                {
                    SpawnTerror();
                }
            }
        }else if(eggStraitTier == 2)
        {
            //Megarhinos + Primanso
            hatchProgress.fillAmount += 0.2f;
            if (countToHatch >= 5)
            {
                int tempRandToHatch;
                tempRandToHatch = Random.Range(0, 100);
                if (tempRandToHatch >= 50)
                {
                    SpawnMega();
                }
                else if (tempRandToHatch < 50)
                {
                    SpawnPrima();
                }
            }
        } else if(eggStraitTier == 3)
        {
            hatchProgress.fillAmount += 0.2f;
            if (countToHatch >= 5)
            {
                int tempRandToHatch;
                tempRandToHatch = Random.Range(0, 100);
                if (tempRandToHatch >= 50)
                {
                    SpawnGigant();
                }
                else if (tempRandToHatch < 50)
                {
                    SpawnTerra();
                }
            }       
        }

    }
    private void SpawnCreepling()
    {
        Instantiate(creepling, gameObject.transform.position, Quaternion.identity);
        mergCtr.OnCountCurrentPower();
        dataCtr.OnUpdateCreepling(0);
        Destroy(gameObject);
    }
    private void SpawnAra()
    {
        Instantiate(arachiling, gameObject.transform.position, Quaternion.identity);
        dataCtr.OnUpdateDataTier2(0, 0);
        Destroy(gameObject);
    }
    private void SpawnTerror()
    {
        Instantiate(terrorling, gameObject.transform.position, Quaternion.identity);
        dataCtr.OnUpdateDataTier2(1, 0);
        Destroy(gameObject);
    }
    private void SpawnMega()
    {
        Instantiate(megarhinos, gameObject.transform.position, Quaternion.identity);
        dataCtr.OnUpdateDataTier3(0, 0);
        Destroy(gameObject);
    }
    private void SpawnPrima()
    {
        Instantiate(primanos, gameObject.transform.position, Quaternion.identity);
        dataCtr.OnUpdateDataTier3(1, 0);
        Destroy(gameObject);
    }
    private void SpawnGigant()
    {
        Instantiate(creepling, gameObject.transform.position, Quaternion.identity);
        dataCtr.OnUpdateDataTier3(0, 0);
        Destroy(gameObject);
    }
    private void SpawnTerra()
    {
        Instantiate(creepling, gameObject.transform.position, Quaternion.identity);
        dataCtr.OnUpdateDataTier3(1, 0);
        Destroy(gameObject);
    }
    private void SpawnDraki()
    {
        Instantiate(creepling, gameObject.transform.position, Quaternion.identity);
        dataCtr.OnUpdateDataTier2(2, 0);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "OBJ_AraDNA")
        {
            if (eggStraitTier == 1)
            {
                eggStraitDNA = 1;
                isCorrectDNA = true;
            }
        }
        else if (collision.gameObject.name == "OBJ_TerrorDNA")
        {
            if (eggStraitTier == 1)
            {
                eggStraitDNA = 2;
                isCorrectDNA = true;
            }
        }
        else if (collision.gameObject.name == "OBJ_DrakiDNA") 
        {
            if (eggStraitTier == 1)
            {
                eggStraitDNA = 3;
                isCorrectDNA = true;
            }
        }
        else if (collision.gameObject.name == "OBJ_MegaDNA")
        {
            if (eggStraitTier == 2)
            {
                eggStraitDNA = 4;
                isCorrectDNA = true;
            }
        }
        else if (collision.gameObject.name == "OBJ_PrimaDNA")
        {
            if (eggStraitTier == 2)
            {
                eggStraitDNA = 5;
                isCorrectDNA = true;
            }
        }
        else if (collision.gameObject.name == "OBJ_GigantDNA")
        {
            if (eggStraitTier == 3)
            {
                eggStraitDNA = 6;
                isCorrectDNA = true;
            }
        }
        else if (collision.gameObject.name == "OBJ_TerraDNA")
        {
            if (eggStraitTier == 3)
            {
                eggStraitDNA = 7;
                isCorrectDNA = true;
            }
        }
    }
}
