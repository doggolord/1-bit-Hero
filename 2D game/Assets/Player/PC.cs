using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
public float Speed;
public float jumpForce;
private float moveInput;

private Rigidbody2D rb;

private bool isGrounded;
public Transform groundCheck;
public float checkRadius;
public LayerMask WhatIsGround;

private int extraJumps;
public int extraJumpsValue;

    void Start() {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    void fixedUpdate() {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, WhatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * Speed, rb.velocity.y);
    }

    void update(){

        if(isGrounded == true){
            extraJumps = extraJumpsValue;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0){
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true){
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
