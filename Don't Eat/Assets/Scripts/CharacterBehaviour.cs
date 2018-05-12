using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBehaviour : MonoBehaviour {

	// character variables
	Rigidbody2D characterRB;

	public Slider fatIndicator;

	// public variables
	public float fatPoint;
	public float characterSpeed;
	public float speedPerFat;

	// Use this for initialization
	void Start () {
		characterRB = this.gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addFat (float amount) {
		fatPoint += amount;
		fatIndicator.value = fatPoint;
		characterSpeed -= Mathf.Abs (fatPoint) * speedPerFat;
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Enemy") {
			// Game Over
		}
	}
}
