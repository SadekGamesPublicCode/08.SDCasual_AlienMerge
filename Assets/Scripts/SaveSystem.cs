using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    [HideInInspector] DataSC dataCtr;
    string path;
    void Awake()
    {
        path = Application.persistentDataPath + "/data.json";
        dataCtr = GameObject.Find("GenMN").GetComponent<DataSC>();
    }
    private void Start()
    {
        dataCtr.OnLoadMorpinos();
    }
    #region Handle Save JSON
    public void OnSaveCreep(int[] array)
    {
        MorpinosData data = Load();
        data.creeplingOnScreen = array;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
    }
    public void OnSaveAra(int[] array)
    {
        MorpinosData data = Load();
        data.araOnscreen = array;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
    }
    public void OnSaveTerror(int[] array)
    {
        MorpinosData data = Load();
        data.terrorOnScreen = array;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
    }
    public void OnSaveDraki(int[] array)
    {
        MorpinosData data = Load();
        data.drakiOnScreen = array;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
    }
    public void OnSaveMega(int[] array)
    {
        MorpinosData data = Load();
        data.megaOnScreen = array;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
    }
    public void OnSavePrima(int[] array)
    {
        MorpinosData data = Load();
        data.primaOnScreen = array;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
    }
    public void OnSaveGigant(int[] array)
    {
        MorpinosData data = Load();
        data.gigantOnScreen = array;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
    }
    public void OnSaveTerra(int[] array)
    {
        MorpinosData data = Load();
        data.terraOnScreen = array;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
    }
    public void OnSaveStruct(int order, int amount)
    {
        MorpinosData data = Load();
        if (order == 0)
        {
            data.imperatosOnScreen = amount;
        }
        else if(order == 1)
        {
            data.nuclepinosOnScreen = amount;
        }
        else if(order == 2)
        {
            data.genopinosOnScreen = amount;
        }
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
    }
    public void OnReset()
    {
        MorpinosData data = Load();
        int[]a = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        data.creeplingOnScreen = a;
        int[]b = { 0, 0, 0, 0, 0 };
        data.terrorOnScreen = b;
        data.araOnscreen = b;
        int[]c = { 0, 0, 0, 0, 0 };
        data.primaOnScreen = c;
        data.megaOnScreen = c;
        int[] d = { 0, 0, 0 };
        data.drakiOnScreen = d;
        data.terraOnScreen = d;
        data.gigantOnScreen = d;
    }
    #endregion
    public MorpinosData Load()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<MorpinosData>(json);
        }
        else
        {
            Debug.Log("No save file found");
            return new MorpinosData();
        }
    }
}
