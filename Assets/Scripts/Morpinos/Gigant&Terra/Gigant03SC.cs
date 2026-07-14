using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gigant03SC : MorpinosSC
{
    [SerializeField] GameObject nextStraitToSpawn;
    void Start()
    {
        morpinosStrait = "Gigant";
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
            mergeCtr.OnCallSpawn(6, morpinosID, transform.position.x, transform.position.y);
            Destroy(collision.gameObject);
        }
    }
}
