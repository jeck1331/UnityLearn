using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float delayTime = 1f;
    void Start()
    {
        Invoke("SpawnObstacle", delayTime);
    }


    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

        Invoke("SpawnObstacle", Random.Range(2, 7));
    }
}
