using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHolder : MonoBehaviour {

	private Transform player;
    public Transform target;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(PauseMenu.gameoverUI == false)
		{
			target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
			
			Vector3 targetDir = target.position - transform.position;
			float rotZ = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler(0f, 0f, rotZ);

			if (rotZ > 90 || rotZ < -90)
			{
				transform.localScale = new Vector3(1f, -1f, 1f);
			} else {
				transform.localScale = new Vector3(1f, 1f, 1f);
			}	
		}
	}
}
