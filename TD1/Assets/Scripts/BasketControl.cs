using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketControl : MonoBehaviour {

    public float space = 4f;
    protected int score = 0;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() {
        // Keyboard controlled
        if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(space * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(-space * Time.deltaTime, 0, 0);
    }

    // collision detection
    private void OnCollisionEnter2D(Collision2D col) {
        score++;
        Debug.Log("Current score:" + score);
    }
}
