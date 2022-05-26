﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = true;
    private float spawnZ = 330;
   private float minSpawn = 0.5f;
    private float maxSpawn = 2;
    public GameObject obstaclePrefab;
    void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnObstacles()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(Random.Range(minSpawn, maxSpawn));
            float randomX = 0;
            switch(Mathf.Floor(Random.Range(0, 3)))
            {
                case 0:
                    randomX = -10;
                    break;
                case 1:
                    randomX = 0;
                    break;
                case 2:
                    randomX = 10;
                    break;
            }
            Instantiate(obstaclePrefab, new Vector3(randomX, 0, 330), obstaclePrefab.transform.rotation);
        }
    }
}