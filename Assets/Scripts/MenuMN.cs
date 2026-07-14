using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMN : MonoBehaviour
{
    [SerializeField] List<GameObject> uiPanels = new List<GameObject>();
    [HideInInspector] DataSC dataCtr;
    [HideInInspector] GenControlSC genCtr;

    [SerializeField] Text curMoney, curGems, curPower;
    [SerializeField] Text curSpawnBoost, curSpawnAmount;
    void Start()
    {
        genCtr = GameObject.Find("GenMN").GetComponent<GenControlSC>();
        dataCtr = GameObject.Find("GenMN").GetComponent<DataSC>();
        HideAllPanels();
        OnUpdateUI();
    }
    void HideAllPanels()
    {
        for (int i = 0; i < uiPanels.Count; i++)
        {
            uiPanels[i].gameObject.SetActive(false);
        }
    }
    public void HidePanel(int panelOrder) => uiPanels[panelOrder].gameObject.SetActive(false);
    public void OnShowPanel(int panelOrder) => uiPanels[panelOrder].gameObject.SetActive(true);
    public void OnCallShowSetting() => genCtr.OnShowSetting(true);
    public void OnUpdateCurPowerUI(int value)
    {
        curPower.text = value.ToString();
    }
    public void OnUpdateUI()
    {
        curMoney.text = dataCtr.pCoin.ToString();
        curGems.text = dataCtr.pGems.ToString();
        curSpawnBoost.text = dataCtr.pEggBonusRate.ToString();
        curSpawnAmount.text = dataCtr.pEggBonusAmount.ToString();
    }
    public void OnGoesTogames(int value)
    {
        switch(value)
        {
            case 0:
                Application.OpenURL("https://play.google.com/store/apps/details?id=com.SDSoft.OrbitalFighter");
                break;
            case 1:
                Application.OpenURL("https://play.google.com/store/apps/details?id=com.SDSoft.TerraInAction");
                break;
            case 2:
                Application.OpenURL("https://play.google.com/store/apps/details?id=com.SDSoft.AgeOfCkauz&");
                break;
        }
    }
    public void OnToConquer()
    {
        genCtr.OnGoesToConquer();
    }
}
