using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creep02SC : MorpinosSC
{
    [SerializeField] GameObject nextStraitToSpawn;
    void Start()
    {
        morpinosStrait = "Creep";
        morpinosID = 1;
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
            mergeCtr.OnCallSpawn(0, morpinosID, transform.position.x, transform.position.y);
            Destroy(collision.gameObject);

        }
    }
}
