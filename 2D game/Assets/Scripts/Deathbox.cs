using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathbox : MonoBehaviour {
	GameObject Player;
	
	
	void Start () {
		Player = GameObject.Find ("Player");

	}

	void Update () {
		if (Player.transform.position.y <= -10) {
			PlayerStats.Lives -= 1;
			Player.transform.position = new Vector3(0, 1, 0);
		}

		if (PlayerStats.Lives <= 0 || Timer.currentTime <= 0)
        {
            Destroy(this);
        }
	}
}