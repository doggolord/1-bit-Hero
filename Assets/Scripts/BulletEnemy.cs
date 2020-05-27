using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour {

	public float speed = 20f;
	public Rigidbody2D rb;
	public ParticleSystem Explosion;
	public int Damage = 10;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
		Explosion.Stop();
	}

	void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
			Instantiate (Explosion, transform.position, transform.rotation);		
            Explosion.Play();
        	PlayerStats.GetHit(Damage);
			Destroy(gameObject);
        	//Debug.Log(PlayerStats.Lives); - to see damage
        }
        else {
            Destroy(gameObject);
        }
    }

	void OnBecameInvisible() {
        Destroy(gameObject);
    }
}