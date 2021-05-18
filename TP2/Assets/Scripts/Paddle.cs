using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
  public float space = 4f;
  public float maxWidth = 8.3f;
  void Start() {}

  // Update is called once per frame
  void Update() {
    // Keyboard control
    if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < maxWidth/2) transform.Translate(space * Time.deltaTime, 0, 0);
    if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -maxWidth/2 ) transform.Translate(-space * Time.deltaTime, 0, 0);
  }

  
}