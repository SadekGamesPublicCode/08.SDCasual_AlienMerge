using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainThemeSC : Singleton<MainThemeSC>
{
    [SerializeField] AudioSource maintheme;
    public bool isAllowTheme;
    private int pMusic; //This variable handle communicate with PlayerPrefs
    private void Start()
    {
        //pMusic = PlayerPrefs.GetInt("");
        //CheckPlayerMusic();
    }
    //private void CheckPlayerMusic()
    //{
    //    if (pMusic == 0) isAllowSound = false;
    //    else if (pMusic == 1)
    //    {
    //        isAllowSound = true;
    //        PlayTheme();
    //    }
    //}
    //public void UpdateMusic(bool isAllow)
    //{
    //    if (isAllow == false)
    //    {
    //        MuteTheme();
    //    }
    //    else PlayTheme();
    //}
    //public void PlayTheme() => maintheme.volume = 1;
    //public void MuteTheme() => maintheme.volume = 0;

    public void PlayTheme() { }
    public void MuteTheme() { }
}
