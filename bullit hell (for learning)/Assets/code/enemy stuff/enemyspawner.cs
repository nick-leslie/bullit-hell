using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour {

    public int spawn;
    public int maxspawn;
    public GameObject TheSpawnedOject;
    public float spawnTimer;
    private float nextwavetimer;
    public float startnextwavetimer;
    public int addtomax;
    public int wavenum;
    public bool spawngo;
    void Start()
    {
        nextwavetimer = startnextwavetimer;
        spawngo = true;
    }
    void Update()
    {
        if (spawngo)
        {
            if (spawn < maxspawn)
            {
                spawnTimer -= Time.deltaTime;
                if (spawnTimer <= 0)
                {
                    Instantiate(TheSpawnedOject, transform.position, transform.rotation);
                    spawnTimer = 3;
                    spawn += 1;
                }
            }
            if (spawn == maxspawn)
            {
                nextwavetimer -= Time.deltaTime;
                if (nextwavetimer <= 0)
                {
                    spawn = 0;
                    maxspawn += addtomax;
                    nextwavetimer = startnextwavetimer;
                    wavenum += 1;
                }
            }
        }
    }
}

