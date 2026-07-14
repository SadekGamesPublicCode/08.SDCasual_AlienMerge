using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drakinos03 : MorpinosSC
{
    [SerializeField] GameObject nextStraitToSpawn;
    void Start()
    {
        morpinosStrait = "Draki";
        morpinosID = 2;
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
            mergeCtr.OnCallSpawn(3, morpinosID, transform.position.x, transform.position.y);
            Destroy(collision.gameObject);

        }
    }
}
