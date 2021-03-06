﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed;
    bool facingRight = true;
	// Use this for initialization
	void Start () 
    {
        //maxSpeed = 100f;
	}
	
	// Update is called once per frame
	void Update () {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");
        var move  = new Vector3(hMove * maxSpeed, vMove * maxSpeed,0);
        GetComponent<Rigidbody2D>().AddForce(move);
        //transform.position += move * Time.deltaTime;
        if (hMove > 0 && !facingRight)
        {
            Flip();
           
        }else if (hMove < 0 && facingRight)
        {
            Flip();
        }
	}

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

        
    }
}
