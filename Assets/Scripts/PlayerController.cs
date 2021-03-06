﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	private MeshRenderer mr;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		mr = GetComponent<MeshRenderer> ();

		Vector3 Vel = rb.velocity;
		Debug.Log ("Start Vel: " + Vel.ToString() );

	}
	 
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pill"))
		{
			other.gameObject.SetActive(false);
		}
	}

	void FixedUpdate ()
	{
		Vector3 Vel = rb.velocity;
		Debug.Log ("FU Vel: " + Vel.ToString() );

		if (Vel.magnitude == 0) {
			Debug.Log ("Zero Magnitude Velocity");
		} else {
			Quaternion Qt = Quaternion.LookRotation (Vel);
			Debug.Log("QT: " + Qt.ToString());
//			mr.transform.rotation = Quaternion.LookRotation (Vel);
			Debug.Log ("LR: " + mr.transform.rotation.ToString());
		}
/*		
		float moveHorizontal = - Input.GetAxis ("Horizontal") * speed;
		float moveVertical = Input.GetAxis ("Vertical") * speed;

		Vector3 rot = new Vector3 (moveVertical, 0.0f, moveHorizontal);

		Board.transform.Rotate (rot, Space.World);
		Walls.transform.Rotate (rot, Space.World);
		Pills.transform.Rotate (rot, Space.World);
		//Board.SetNormalAndPosition (Normal, new Vector3 (0.0f, 0.0f, 00.0f));
		//		rb.AddForce (movement);
		Player.transform.Rotate (rot);
*/
	}
}
