using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
  public float space = 4f;

  void Start() {}

  // Update is called once per frame
  void Update() {
    // Keyboard control
    if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 8) transform.Translate(space * Time.deltaTime, 0, 0);
    if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -8 ) transform.Translate(-space * Time.deltaTime, 0, 0);
  }

  
}