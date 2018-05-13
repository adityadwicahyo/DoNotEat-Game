using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour {

	public float moveSpeed;
	private float timeLimit = 10.0f;


	private Rigidbody2D myRigidbody;
	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		myRigidbody.velocity = new Vector2 (moveSpeed, myRigidbody.velocity.y);

		if(Time.time >= timeLimit)
		{
      	// Add 1 to the moveSpeed...
			moveSpeed += 0.5f;
      	// make it wait another 30 mins...
			timeLimit += 10.0f;
		}
	}
}
