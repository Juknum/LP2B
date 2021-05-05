using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Apple : MonoBehaviour {
	public bool infiniteFall = true;

	// Start is called before the first frame update
	void Start() {}

	// Update is called once per frame
	void Update() {}

	private void OnBecameInvisible() {

		if (infiniteFall) {
			var pos = gameObject.transform.position;
			gameObject.transform.position = new Vector2(pos.x, 8);
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		}
		else {
			Destroy(gameObject);
		}
	}

	private void OnCollisionEnter2D(Collision2D col) {
		Destroy(gameObject);
	}
}
