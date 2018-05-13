using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterBehaviour : MonoBehaviour {

	// character variables
	Rigidbody2D characterRB;
	//Animator charAnim;

	public Slider fatIndicator;

	// public variables
	public float fatPoint;
	public float maxSpeed;
	public float speedPerFat;
	public float hungerTimePerSecond;

	float nextHunger;
	float nowSpeed;
	float timeLimit = 10.0f;


	// Use this for initialization
	void Start () {
		characterRB = GetComponent<Rigidbody2D> ();
		//charAnim = GetComponent<Animator> ();

		nextHunger = hungerTimePerSecond;
		nowSpeed = maxSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextHunger) {
			nextHunger += hungerTimePerSecond;
			fatPoint -= 1;
		}

		if(Time.time >= timeLimit)
		{
      	// Add 1 to the moveSpeed...
			maxSpeed += 0.5f;
			nowSpeed += 0.5f;
      	// make it wait another 30 mins...
			timeLimit += 10.0f;
		}
	}

	void FixedUpdate () {
		characterRB.velocity = new Vector2(nowSpeed, characterRB.velocity.y);
		nowSpeed = maxSpeed - (Mathf.Abs (fatPoint) * speedPerFat);
		fatIndicator.value = fatPoint;
	}

	public void addFat (float amount) {
		fatPoint += amount;
		
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Enemy") {
			// Game Over
			Destroy (gameObject);
			SceneManager.LoadScene("gameover", LoadSceneMode.Additive);
		}
	}
}
