using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawner : MonoBehaviour
{

    public float spawnRate = 5f;
    public float spawnRadius = 5f;
    public GameObject healthPrefab;
    void Start()
    {
        InvokeRepeating("Spawn",0 , spawnRate);
    }
    void Spawn() {
        var spawnPos = transform.position + Random.insideUnitSphere * spawnRadius;
        Instantiate(healthPrefab, spawnPos, Quaternion.identity);
    }
}
