﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seppuku : MonoBehaviour
{

	public Transform playerT;

	private Transform selfT;

	// Start is called before the first frame update
	void Start()
	{

		selfT = GetComponent<Transform>();

		GameObject player = GameObject.FindGameObjectWithTag("Player");

		playerT = player.transform;

	}

	// Update is called once per frame
	void Update()
	{

		if (playerT.position.y - selfT.position.y > 5)
		{
			Destroy(gameObject);
		}

	}
}
