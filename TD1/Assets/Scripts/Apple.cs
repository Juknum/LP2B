using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {
    public bool infiniteFall = true;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() {}

    private void OnBecameInvisible() {

        if (infiniteFall)
        {
            var pos = gameObject.transform.position;
            gameObject.transform.position = new Vector3(pos.x, 8, pos.z);
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D col) {
        Destroy(gameObject);
    }
}
