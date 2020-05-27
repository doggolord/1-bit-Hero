using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour {

	public float JumpForce = 600f;
	Rigidbody2D rb;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Enemy"){
		//	other.rb.AddForce(Vector2.up * JumpForce, ForceMode.Acceleration);
		}
	}
}
