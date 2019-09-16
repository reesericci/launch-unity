using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
public float rainbowSpeed = 0.5f;
public Material colorChange;

private float h, s, v;

void Start() {
  Color.RGBToHSV(colorChange.color, out h, out s, out v);
  if (s == 0) {
    h = 1;
    s = 1;
    v = 1;
  }
}

void Update() {
  h = h + Time.deltaTime * rainbowSpeed;
  h = h % 1.0f;
  colorChange.color = Color.HSVToRGB(h, s, v);

}

}
