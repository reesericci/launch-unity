using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

public float yawSpeed = 6.0f;
public float pitchSpeed = 4.0f;
	// Use this for initialization
	void Start () {
  	Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update () {
		float yaw = Input.GetAxis("Mouse X");
		float pitch = Input.GetAxis("Mouse Y");

		yaw *= yawSpeed;
		pitch *= pitchSpeed;

		pitch *= -1;

		transform.Rotate(pitch, 0, 0);
		transform.Rotate(0,yaw,0,Space.World);
		if (Input.GetKeyDown("escape")) {
			Cursor.lockState = CursorLockMode.None;
}
	}
}
