using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    // public GameObject[] obstaclePrefabs;
    private float[] spawnPos;
    private float minDelay = 3;
    private float maxDelay = 7;
    public PlayerController playerController;


    // Start is called before the first frame update
    void Start()
    {
        spawnPos = playerController.GetMoveablePosition();
        Invoke("SpawnRandomEnemy", Random.Range(minDelay, maxDelay));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomEnemy()
    {
        float delay = Random.Range(minDelay, maxDelay);

        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        int spawnIndex = Random.Range(0, spawnPos.Length);
        Vector3 enemySpawnPos = new Vector3(spawnPos[spawnIndex], 0.5f, 10);

        Instantiate(enemyPrefabs[enemyIndex], enemySpawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        Invoke("SpawnRandomEnemy", delay);
    }
}
