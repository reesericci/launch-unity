using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aCameraControl : MonoBehaviour {

public enum ControlTypes {
	Flying,
	Walking
}
public ControlTypes controlMode;
public GameObject playerCamera;

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

switch(controlMode) {
	case ControlTypes.Flying:
	transform.Rotate(pitch, 0, 0);
	transform.Rotate(0,yaw,0,Space.World);
	break;

	case ControlTypes.Walking:
	playerCamera.transform.Rotate(pitch, 0, 0);
	transform.Rotate(0,yaw,0,Space.World);
	break;
}

		if (Input.GetKeyDown("escape")) {
			Cursor.lockState = CursorLockMode.None;
}
	}
}
