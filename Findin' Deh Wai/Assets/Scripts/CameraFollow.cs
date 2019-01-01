using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	public Transform playerT;
	public Transform cameraT;

	//change in height
	private float deltaH = 0f;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		if (playerT.position.y > cameraT.position.y)
		{

			deltaH = playerT.position.y;
			
		}

	}

	void LateUpdate()
	{

		if(deltaH > cameraT.position.y)
		{
			Vector3 newPosition = cameraT.position;
			newPosition.y = deltaH;

			cameraT.position = newPosition;
		}
		
	}
}
