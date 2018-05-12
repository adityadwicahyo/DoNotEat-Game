using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour {

	// public variables
	public float foodAmount;
	public float hiddenHealth;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hiddenHealth == 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			CharacterBehaviour theCharacter = other.gameObject.GetComponent<CharacterBehaviour> ();
			theCharacter.addFat (foodAmount);
			Destroy (gameObject);
		}
	}

	void OnMouseOver () {
		if (Input.GetMouseButtonDown (0) == true) {
			hiddenHealth -= 1;
		}
	}
}
