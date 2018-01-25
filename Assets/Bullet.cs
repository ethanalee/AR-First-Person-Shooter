using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Destroy(gameObject, 5);
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.forward * Time.deltaTime * 30);
		
	}

	public void OnCollisionEnter (Collision col){

		Destroy(col.gameObject);
		Destroy(gameObject);

	}
}
