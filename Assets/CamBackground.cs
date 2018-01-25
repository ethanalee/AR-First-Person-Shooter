using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBackground : MonoBehaviour {

	public GameObject background;

	WebCamTexture backCam;

	// Use this for initialization
	void Start () {

		Screen.sleepTimeout = SleepTimeout.NeverSleep;

		if(backCam == null){
			backCam = new WebCamTexture();
		}

		background.GetComponent<Renderer>().material.mainTexture = backCam;

		if(!backCam.isPlaying){
			backCam.Play();
		}
	}

	// Update is called once per frame
	void Update () {

		
	}

}
