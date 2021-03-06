﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dust : MonoBehaviour {
	
	public float obstacleSpeed;
	ObstacleManager obstacleManager;

	void Start() {
		obstacleManager = GetComponent<ObstacleManager> ();
	}

	void Update () {
		obstacleSpeed = 5.0f * Time.deltaTime;

		transform.position = new Vector2 (transform.position.x - obstacleSpeed, 0);

		obstacleManager.destroy ();
	}
}
