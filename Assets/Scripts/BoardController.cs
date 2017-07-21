using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour {
	public float speed;
	public GameObject Walls;
	public GameObject Player;
	public GameObject Pills;

	private GameObject Board;

	void Start ()
	{
//		GameObject W;
		Board = gameObject;

//		for (int i = 0; i < 5; i++) {
//			W = Instantiate (wall);
//			W.transform.Translate (new Vector3 (3 * i, 0, 0));
//			W.transform.SetParent (Board.transform);
//		}
//		Border11.transform.SetParent (Board.transform);
//		Border12.transform.SetParent (Board.transform);
//		Border13.transform.SetParent (Board.transform);
//		Border14.transform.SetParent (Board.transform);
	}
		
	// Update is called once per frame
	void Update () {
		float moveHorizontal = - Input.GetAxis ("Horizontal") * speed;
		float moveVertical = Input.GetAxis ("Vertical") * speed;

		Vector3 rot = new Vector3 (moveVertical, 0.0f, moveHorizontal);

		Board.transform.Rotate (rot, Space.World);
		Walls.transform.Rotate (rot, Space.World);
		Pills.transform.Rotate (rot, Space.World);
		//Board.SetNormalAndPosition (Normal, new Vector3 (0.0f, 0.0f, 00.0f));
		//		rb.AddForce (movement);
		Player.transform.Rotate (rot);
	}
}
