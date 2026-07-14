using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prima01SC : MorpinosSC
{
    [SerializeField] GameObject nextStraitToSpawn;
    void Start()
    {
        morpinosStrait = "Prima";
        morpinosID = 0;
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
            mergeCtr.OnCallSpawn(5, morpinosID, transform.position.x, transform.position.y);
            Destroy(collision.gameObject);
        }
    }
}
