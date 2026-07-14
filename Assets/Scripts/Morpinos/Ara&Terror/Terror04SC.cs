using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terror04SC : MorpinosSC
{
    [SerializeField] GameObject nextStraitToSpawn;
    void Start()
    {
        morpinosStrait = "Ara";
        morpinosID = 3;
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
            Destroy(collision.gameObject);
            mergeCtr.OnCallSpawn(2, morpinosID, transform.position.x, transform.position.y);
        }
    }
}
