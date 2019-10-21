using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public
class PlayerMotion : MonoBehaviour {

public
  float speed = 10.0F;
  // Use this for initialization
  void Start() {}

  // Update is called once per frame
  void Update() {

    float forwardMotion;
    float sideMotion;


    forwardMotion = Input.GetAxis("Horizontal");
    sideMotion = Input.GetAxis("Vertical");

    forwardMotion *= speed;
    sideMotion *= speed;

    forwardMotion *= Time.deltaTime;
    sideMotion *= Time.deltaTime;
    
    transform.Translate(sideMotion, 0, forwardMotion);
  }
}
