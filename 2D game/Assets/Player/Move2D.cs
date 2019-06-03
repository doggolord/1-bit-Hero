using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour {
	public float moveSpeed = 5f;
	public bool isGrounded = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Jump();
		Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
		transform.position += movement * Time.deltaTime * moveSpeed;
	}

	void Jump (){
		if (Input.GetButtonDown("Jump") && isGrounded == true){
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
		}
		
	}
}
