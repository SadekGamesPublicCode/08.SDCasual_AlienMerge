using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConquerSC : MonoBehaviour
{
    [HideInInspector] DataSC dataCtr;
    [HideInInspector] GenControlSC genCtr;

    [SerializeField] Text curMoney, curGems, curPower;
    void Start()
    {
        genCtr = GameObject.Find("GenMN").GetComponent<GenControlSC>();
        dataCtr = GameObject.Find("GenMN").GetComponent<DataSC>();
        OnUpdateUI();
    }

    public void OnUpdateUI()
    {
        curMoney.text = dataCtr.pCoin.ToString();
        curGems.text = dataCtr.pGems.ToString();
        curPower.text = dataCtr.pTotalScore.ToString();
    }
    public void ToHatchery()
    {
        genCtr.OnGoesToHatchery();
    }
    public void OnShowSetting() => genCtr.OnShowSetting(true);
}
