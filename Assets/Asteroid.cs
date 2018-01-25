using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	Vector3 direction;

	// Use this for initialization
	void Start () {

		Destroy(gameObject, 10);
		
	}
	
	// Update is called once per frame
	void Update () {

		direction = Vector3.MoveTowards (transform.position, Vector3.zero, 0);
		transform.Translate (-direction * Time.deltaTime * 0.5f);

		if (Vector3.Distance (transform.position, Vector3.zero) < 2) {
			Destroy (gameObject);
		}
		
	}
}
