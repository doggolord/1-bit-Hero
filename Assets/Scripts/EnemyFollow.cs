using System.Collections;
using System.Collections.Generic;
using UnityEngine;	

public class EnemyFollow : MonoBehaviour {

	public float speed;
	public float stoppingDistance;
	public Transform player;
	private Transform target;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Vector2.Distance(transform.position, target.position) > stoppingDistance){
			transform.position = Vector2.MoveTowards (transform.position, new Vector2(target.position.x, transform.position.y), speed * Time.deltaTime);
		}

		if (PlayerStats.Lives <= 0 || Timer.currentTime <= 0)
        {
            Destroy(this);
        } 
	}
	
	
}