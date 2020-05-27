using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 20f;
	public Rigidbody2D rb;
    public ParticleSystem Explosion;
    public int Damage = 25;
    public bool offScreenDestroy = true;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate (Explosion, transform.position, transform.rotation);	
            Explosion.Play();
            collision.gameObject.GetComponent<EnemyHealth>().GetHit(Damage);
            //Debug.Log(collision.gameObject.GetComponent<EnemyHealth>().Lives); //- to see damage
            Destroy(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }
    
    void OnBecameInvisible() {
        if(offScreenDestroy == true){
            Destroy(gameObject);
        }
    }
}