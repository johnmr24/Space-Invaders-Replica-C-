using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour
{
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 2f;
    public GameObject meteorPrefab;
    public float totalTimeElapsed = 0f;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        totalTimeElapsed += Time.deltaTime;

        //every 15 seconds, the meteors will start to spawn faster
        if (totalTimeElapsed >= 10)
        {
            if (minSpawnDelay > 0)
            {
                minSpawnDelay -= 0.25f;
                maxSpawnDelay -= 0.25f;
                totalTimeElapsed = 0f;
            }
            else
            {
                if (maxSpawnDelay > 0)
                {
                    maxSpawnDelay -= 0.25f;
                    totalTimeElapsed = 0f;
                }
            }
        }
    }

    void Spawn()
    {
        Vector3 spawnPos = transform.position + new Vector3(Random.Range(-6, 6), 0, 0);
        Instantiate(meteorPrefab, spawnPos, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }

}
