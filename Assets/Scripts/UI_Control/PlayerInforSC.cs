using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInforSC : MonoBehaviour
{
    [SerializeField] Text pName, pStrenght, pMoney, pGems;
    [HideInInspector] DataSC data;
    private void Awake()
    {
        data = GameObject.Find("GenMN").GetComponent<DataSC>();
    }
    private void OnEnable()
    {
        pName.text = "Alien Farm";
        pStrenght.text = data.pTotalScore.ToString();
        pMoney.text = data.pCoin.ToString();
        pGems.text = data.pGems.ToString();
    }
}
