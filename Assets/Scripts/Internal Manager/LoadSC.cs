using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSC : MonoBehaviour
{
    [SerializeField] SceneSC sceneMN;
    [SerializeField] Slider loadSlide;

    [Header("Variables")]
    private float loadSpd;
    void Start()
    {
        sceneMN = GameObject.Find("GenMN").GetComponent<SceneSC>();
        SetupStart();
        StartCoroutine(RunLoad());
    }
    void SetupStart()
    {
        loadSlide.value = 0;
    }
    IEnumerator RunLoad()
    {
        loadSpd = Random.Range(0.01f, 0.9f);
        if (loadSlide.value >= 1)
        {
            StopCoroutine(RunLoad());
            sceneMN.LoadScene(1);
        }
        yield return new WaitForSeconds(0.1f);
        loadSlide.value += loadSpd * Time.deltaTime * 10;
        StartCoroutine(RunLoad());
    }
}
