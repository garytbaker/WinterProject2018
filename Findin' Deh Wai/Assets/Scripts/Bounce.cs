﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

	public float jumpForce = 10f;

	void OnCollisionEnter2D(Collision2D collision)
	{
		Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
		if (collision.relativeVelocity.y <= 0f)
		{
			if (rb != null)
			{
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
				Destroy(gameObject);
			}
		}
	}
}
