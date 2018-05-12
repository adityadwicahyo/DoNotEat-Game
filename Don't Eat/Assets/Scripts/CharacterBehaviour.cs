using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour {

	// public variables
	public float fatPoint;
	public float characterSpeed;
	public float speedPerFat;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		characterSpeed -= Mathf.Abs (fatPoint) * speedPerFat;
	}

	public void addFat (float amount)
	{
		fatPoint += amount;
	}
}
