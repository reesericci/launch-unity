using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour {

public float turnSpeed = 25;
public float movementSpeed = 2;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(0, Time.deltaTime * turnSpeed, 0);

		transform.Translate(Time.deltaTime * movementSpeed, 0, 0);
	}
}
