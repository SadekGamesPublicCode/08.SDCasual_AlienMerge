using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSC : Singleton<SceneSC>
{
    GenControlSC genCtr;
    private void Start() 
    {
        genCtr = GameObject.Find("GenMN").GetComponent<GenControlSC>();
    }
    public void LoadScene(int sceneOder)
    {
        switch (sceneOder)
        {
            case 0:
                SceneManager.LoadScene("00_LoadScene");
                break;
            case 1:
                SceneManager.LoadScene("01_MainScene");
                genCtr.OnAssistElements(1);
                break;
            case 2:
                SceneManager.LoadScene("02_ConquerScene");
                break;
        }
    }
}
