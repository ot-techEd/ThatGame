using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] itemsToSpawn;
    [SerializeField] private Transform[] spawnPoints;


    [Range(0.5f, 5.0f)]
    [SerializeField] private float spawnTime = 1.0f;

    [Range(0.5f, 5.0f)]
    [SerializeField] private float repeatRate = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacles), spawnTime, repeatRate);
    }


    private void SpawnObstacles()
    {
        int randomSpawnPoint = GetRandomNumber(spawnPoints.Length);
        GameObject obstacle = Instantiate(itemsToSpawn[GetRandomNumber(itemsToSpawn.Length)],
            spawnPoints[randomSpawnPoint].position, spawnPoints[randomSpawnPoint].rotation);
    }

    private int GetRandomNumber(int maxLength)
    {
        return Random.Range(0, maxLength);
    }
}
