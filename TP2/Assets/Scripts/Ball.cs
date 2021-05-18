using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour {
  public TextMeshPro DisplayedText;
  public int score = 0;
  private float resetTimer = 0f;
  private bool isBeingReset = false;

  // Start is called before the first frame update
  void Start() {}

  // Update is called once per frame
  void Update() {
    resetTimer += Time.deltaTime;

    if (resetTimer < 2f && isBeingReset) {
      gameObject.transform.position = new Vector2(0, -1);
      GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
    else {
      resetTimer = 0f;
      isBeingReset = false;
    }
  }

  private void OnBecameInvisible() {
    resetTimer = 0f;
    score = score - 500 > 0 ? score - 500 : 0;

    DisplayedText.SetText("Score: " + score);
    isBeingReset = true;
  }

  private void OnCollisionEnter2D(Collision2D col) {

    if (col.gameObject.name == "Brick" || col.gameObject.name == "Brick(Clone)") {
      score += 50;
      Debug.Log("Current score:" + score);
      Destroy(col.gameObject);

      DisplayedText.SetText("Score: " + score);

      GameMaster.setReportBrickDeath(GameMaster.ReportBrickDeath() - 1);
      Debug.Log(GameMaster.ReportBrickDeath());
    }

    if (col.gameObject.name == "Paddle") {

      float diffX = gameObject.transform.position.x - col.gameObject.transform.position.x;
      GetComponent<Rigidbody2D>().velocity += new Vector2(diffX * 3, 0);
    }
  }
}
