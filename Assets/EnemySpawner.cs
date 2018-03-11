using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public GameObject[] enemies;

    public GameObject leftLimit;
    public GameObject rightLimit;

    public float spawnRate;
    float timeSinceLastSpawn;

    Vector3 generatePosition() {
        Vector3 ret;
        float rand = Random.Range(0.0f,1.0f);
        ret.x = Mathf.Lerp(leftLimit.transform.position.x, rightLimit.transform.position.x, rand);
        ret.y = Mathf.Lerp(leftLimit.transform.position.y, rightLimit.transform.position.y, rand);
        ret.z = Mathf.Lerp(leftLimit.transform.position.z, rightLimit.transform.position.z, rand);
        return ret;
    }

    void spawnEnemy() {
        int typeEnemy=(int)Mathf.Floor(Random.Range(0, enemies.Length));

        Instantiate(enemies[typeEnemy], generatePosition(), enemies[typeEnemy].transform.rotation);
    }
    void start() {
        spawnRate = 1 / spawnRate;
    }

	// Update is called once per frame
	void Update () {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn > spawnRate) {
            spawnEnemy();
            timeSinceLastSpawn -= spawnRate;
        }
		
	}
}
