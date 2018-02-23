﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.AccessControl;
using UnityEngine.Experimental.UIElements.StyleEnums;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour {
	
	public float moveSpeed = 0.3f;

	public KeyCode rightKey = KeyCode.D;
	public KeyCode leftKey = KeyCode.A;
	public KeyCode fireKey = KeyCode.Space;

	public GameObject projectilePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (rightKey)){
			transform.Translate (moveSpeed, 0, 0);
			GetComponent<SpriteRenderer> ().flipX = false;
		}
			if(Input.GetKey (leftKey)){
				transform.Translate (-moveSpeed, 0, 0);
			GetComponent<SpriteRenderer>().flipX = true;
			}

		if (transform.position.x > 115) {
			SceneManager.LoadScene (1);
		}

		if (Input.GetKeyDown (fireKey)) {
			GameObject newProjectileObj = Instantiate (projectilePrefab);
<<<<<<< HEAD
			newProjectileObj.transform.position = new Vector3 (transform.position.x+3, transform.position.y-0.5f, 0);
=======
			newProjectileObj.transform.position = transform.position;
>>>>>>> master
		}

	}
}
