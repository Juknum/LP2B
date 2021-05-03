using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningWall : MonoBehaviour {
  public float rotation = 10f;

  void Start() {}

  // Update is called once per frame
  void Update() {
    rotation += rotation;

    if (rotation >= 180f) rotation = (180f - rotation) > 0f ? 180f - rotation : rotation - 180f;
    transform.Rotate(0, 0, rotation * Time.deltaTime);
  }
}