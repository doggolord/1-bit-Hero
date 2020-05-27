using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
  public float speed = 5f;
  private float movement = 0f;
  public float jumpPower = 4f;
	public bool candoublejump;
	public bool isGrounded = false;
  private Rigidbody2D rigidBody;
  public ParticleSystem Death;
  public ParticleSystem Jumping;

  // Use this for initialization
  void Start () {
    rigidBody = GetComponent<Rigidbody2D> ();
    Death.Stop();
    Jumping.Stop();
  }
  
  // Update is called once per frame
  void Update () {
    Jump();
    movement = Input.GetAxis ("Horizontal");

    if (movement > 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    }
    else if (movement < 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    }
    else {
      rigidBody.velocity = new Vector2 (0,rigidBody.velocity.y);
    }

    if (PlayerStats.Lives <= 0)
    {
      Blood();
    }
  }
  
  void Jump (){
		if (Input.GetButtonDown("Jump")){
			if(isGrounded == true){
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpPower), ForceMode2D.Impulse);
        candoublejump = true;
        Instantiate (Jumping, transform.position, transform.rotation);		
        Jumping.Play();
  
			}else if (candoublejump) {
        rigidBody.velocity = Vector3.zero;
				candoublejump = false;
				gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpPower), ForceMode2D.Impulse);
        Instantiate (Jumping, transform.position, transform.rotation);		
        Jumping.Play();
      }
		}
	}

  void Blood() {
    Instantiate (Death, transform.position, transform.rotation);		
    Death.Play();
  }
}