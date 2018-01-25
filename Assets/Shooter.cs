using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	public AudioClip shot;
	public AudioSource source;
	public GameObject bullet;

	float timer = 0;
	bool shooting = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(shooting){
			timer += Time.deltaTime;
			if (timer > 0.125) {
				shooting = false;
				timer = 0;
			}
		}

		if(Input.GetMouseButton(0) && !shooting){
			shooting = true;
			source.PlayOneShot(shot);

			Instantiate(bullet, new Vector3 (0, -0.1f, 0), transform.rotation);
		}

	}
}
