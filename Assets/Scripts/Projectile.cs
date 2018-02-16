﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float moveSpeed = 10f;

	public float maxX = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate( moveSpeed*Time.deltaTime , 0, 0);
		//transform.Rotate (3, 0, 0);

		if (transform.position.x > maxX) {
			Destroy(gameObject);
		}
			
	}

	void OnTriggerEnter2D(Collider2D otherCollider) {
		Destroy(otherCollider.gameObject);
		Destroy(gameObject);
		//GameManager.instance.score++;
	}
}
