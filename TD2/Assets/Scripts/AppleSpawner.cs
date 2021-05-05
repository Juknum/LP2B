using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour {
	public GameObject ApplePrefab;
	public float TIME_MIN = .2f;
	public float TIME_MAX = 1.5f;

	private float TIME;
	private float currentTime;

	// Start is called before the first frame update
	void Start() {
		GameObject newApple = Instantiate(ApplePrefab);
		newApple.transform.position = new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(4f, 6f), .1f);
	}

	// Update is called once per frame
	void Update() {
		currentTime += Time.deltaTime;
		TIME = Random.Range(TIME_MIN, TIME_MAX);

		if (currentTime >= TIME) {
			currentTime -= TIME;

			GameObject newApple = Instantiate(ApplePrefab);
			newApple.transform.position = new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(4f, 6f), .1f);
		}
	}
}
