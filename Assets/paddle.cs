using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paddle : MonoBehaviour {
    public float speed = 5f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

        if (Input.GetKey("left") && transform.position.x > -4.75) {
            //Time.deltaTime is computer time in seconds so if there is lag it stay consistent
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("right") && transform.position.x < 4.75) {
            //Time.deltaTime is computer time in seconds so if there is lag it stay consistent
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
	}
}
