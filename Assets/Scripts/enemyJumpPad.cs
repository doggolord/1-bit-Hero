using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyJumpPad : MonoBehaviour {
	public int speed;//Speed has to be atleast 500 to show some effect

     void OnTriggerEnter2D(Collider2D other)
     {
         if (other.gameObject.CompareTag("Enemy"))
         {
             other.gameObject.GetComponent<Rigidbody2D>
                     ().AddForce(Vector2.up*speed);
         }
     }
}
