﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour {
	
	public GameObject thePlatform;
	public Transform generationPoint;
	public float distanceBetween;

	private float platformWidth;

	void Start () {
		platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < generationPoint.position.x){
			transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);

			// platformSelector = Random.Range(0, theObjectPools.Length);

			Instantiate (thePlatform, transform.position, transform.rotation);
			
			// GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();

			// newPlatform.transform.position = transform.position;
			// newPlatform.transform.rotation = transform.rotation;
			// newPlatform.SetActive(true);
		}
	}
}
