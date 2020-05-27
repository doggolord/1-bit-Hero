using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {
	public float X1 = 0;
	public float X2 = 0;
	public GameObject Enemy;
	float randX;
	Vector2 whereToSpawn;
	public float spawnRate = 2f;
	float nextSpawn = 0.0f;

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		
		if (Time.time > nextSpawn){
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range (X1, X2);
			whereToSpawn = new Vector2 (randX, transform.position.y);
			Instantiate (Enemy, whereToSpawn, Quaternion.identity);
		}

        if (PlayerStats.Lives <= 0)
        {
            Destroy(this);
        }

	}
}
