using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy;

    public Vector3 spawnArea;

    public float spawnTime;

    private float timer;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            SpawnEnemy();
            timer = spawnTime;
        }
    }

    private void SpawnEnemy()
    {
        //xy的 怪物生成範圍
        Vector3 position =
            new Vector3(UnityEngine.Random.Range(-spawnArea.x, spawnArea.x),
                UnityEngine.Random.Range(-spawnArea.y, spawnArea.y),
                0f);

        GameObject newEnemy = Instantiate(enemy);
        newEnemy.transform.position = position;
    }
}
