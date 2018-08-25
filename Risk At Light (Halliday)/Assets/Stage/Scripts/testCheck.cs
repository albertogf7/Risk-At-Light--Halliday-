using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCheck : MonoBehaviour {


	public GameObject pathToActivate;

	public AudioSource machineSpeaker;
	public AudioClip motorOn;

	public AudioSource mouthball;
	public AudioClip ventLoosing;

	public GameObject floorPlat;

	// Use this for initialization
	void Start () {
		machineSpeaker = GetComponent<AudioSource> ();


		pathToActivate.SetActive (false);
	
	}

	void OnCollisionEnter(Collision fruit)
	{
		if (fruit.gameObject.tag == "appleTest") {
			machineSpeaker.clip = motorOn;
			machineSpeaker.PlayOneShot (motorOn, 0.6f);
			fruit.gameObject.SetActive (false);
			pathToActivate.SetActive (true);
		

			Debug.Log ("machine On");

		} 

		else if (fruit.gameObject.tag != "appleTest")
		{
			floorPlat.SetActive (false);
			mouthball.clip = ventLoosing;
			mouthball.PlayOneShot (ventLoosing, 0.5f);
		}
	}
}
