﻿using UnityEngine;
using System.Collections;

public class ShotLife : MonoBehaviour {

	public int damage =1;
	public bool isEnemyShot = false;

	// Use this for initialization

	void Start () {

		Destroy (gameObject, 1); 

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
