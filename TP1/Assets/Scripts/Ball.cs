using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
  public int score = 0;
  public bool infiniteFall = true;

  // Start is called before the first frame update
  void Start() {}

  // Update is called once per frame
  void Update() {}

  private void OnBecameInvisible() {

    if (infiniteFall)
    {
      gameObject.transform.position = new Vector2(0, 4);
      GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
    else
    {
      Destroy(gameObject);
    }

    score = 0;
  }

  private void OnCollisionEnter2D(Collision2D col) {

    if (col.gameObject.name == "Paddle") {
      score++;
      Debug.Log("Current score:" + score);  
    }

  }
}
