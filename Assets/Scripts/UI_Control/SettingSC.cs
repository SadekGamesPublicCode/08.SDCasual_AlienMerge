using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingSC : MonoBehaviour
{
    private SoundSC soundSFX;
    private MainThemeSC soundTheme;
    [HideInInspector] GenControlSC genCtrl;
    [HideInInspector] DataSC data;

    [SerializeField] GameObject creditPnl, inforPnl;
    [SerializeField] Button soundTG, sfxToggle;
    [SerializeField] Image soundOnImg, soundOffImg, sfxOnImg, sfxOffImg;

    int themeAllow, sfxAllow;
    void Start()
    {
        data = GameObject.Find("GenMN").GetComponent<DataSC>();
        soundTheme = GameObject.Find("GenMN").GetComponent<MainThemeSC>();
        soundSFX = GameObject.Find("GenMN").GetComponent<SoundSC>();
        CheckSound();
    }

    public void OnToggleSound()
    {
        if (soundTheme.isAllowTheme == true)
        {
            soundTheme.MuteTheme();
        }
        else if(soundTheme.isAllowTheme == false)
        {
            soundTheme.PlayTheme();
        } 
    }
    public void OnToggleSFX()
    {
        if (soundSFX.isAllowSFX == true)
        {
            soundSFX.MuteSFX();
        }
        else if(soundSFX.isAllowSFX == false)
        {
            soundSFX.PlaySFX();
        }
    }
    public void ToCredits()
    {
        creditPnl.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
    public void ToInfors()
    {
        inforPnl.gameObject.SetActive(true);
        gameObject.SetActive(false );
    }
    public void ExitGame() => Application.Quit();
    public void CheckSound()
    {
        themeAllow = data.pTheme;
        sfxAllow = data.pSFX;
        switch (themeAllow)
        {
            case 0:
                soundOnImg.gameObject.SetActive(true);
                soundOffImg.gameObject.SetActive(false);
                //soundTheme.MuteTheme();
                break;
            case 1:
                soundOnImg.gameObject.SetActive(false);
                soundOffImg.gameObject.SetActive(true);
                //soundTheme.PlayTheme();
                break;
        }

        switch (sfxAllow)
        {
            case 0:
                sfxOnImg.gameObject.SetActive(true);
                sfxOffImg.gameObject.SetActive(false);
                //soundSFX.MuteSFX();
                break;
            case 1:
                sfxOnImg.gameObject.SetActive(false);
                sfxOffImg.gameObject.SetActive(true);
                //soundSFX.PlaySFX();
                break;
        }
    }
}
