﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{

	private float movement = 0f;
	public float movementSpeed = 10f;

	Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {

	    rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

	    movement = Input.GetAxis("Horizontal") * movementSpeed;
        
    }

    void FixedUpdate()
    {

	    Vector2 velocity = rb.velocity;
	    velocity.x = movement;
	    rb.velocity = velocity;
    
    }
}
