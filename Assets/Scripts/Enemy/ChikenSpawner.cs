using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ChickenAttack
{
    public class ChikenSpawner : ObjectPool
    {
        [SerializeField] private GameObject chikenPrefab;
        [SerializeField] private Transform[] spawnPoints;
        [SerializeField] private float secondBetweenSpawn;
    
        private float timer = 0f;

        private void Start()
        {
            _capacity = 15;
            Initialize(chikenPrefab);
        }

        private void Update()
        {
            timer += Time.deltaTime;
            if (timer >= secondBetweenSpawn)
            {
                if (TryGetObject(out GameObject chiken))
                {
                    timer = 0;
                    int spawnPoint = Random.Range(0, spawnPoints.Length);
                    SetChiken(chiken, spawnPoints[spawnPoint].position);
                }
            }
        }

        private void SetChiken(GameObject chiken, Vector3 point)
        {
            chiken.SetActive(true);
            chiken.transform.position = point;
        }
    }
}

