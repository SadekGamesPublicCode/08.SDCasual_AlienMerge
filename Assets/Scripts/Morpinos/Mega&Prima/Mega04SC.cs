using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mega04SC : MorpinosSC
{
    [SerializeField] GameObject nextStraitToSpawn;
    void Start()
    {
        morpinosStrait = "Mega";
        morpinosID = 4;
        morpinosName = gameObject.name;
        base.Start();
    }
    private void Update()
    {
        base.Update();
    }
    internal void OnTriggerEnter2D(Collider2D collision)
    {
        string colName = collision.gameObject.name;
        if (colName == morpinosName)
        {
            mergeCtr.OnCallSpawn(4, morpinosID, transform.position.x, transform.position.y);
            Destroy(collision.gameObject);
        }
    }
}
