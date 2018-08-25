using UnityEngine;
using System.Collections;

public class MouthSound : MonoBehaviour

{
	public Collider mouth;
	private AudioClip[] FruitSounds;

	public AudioSource Chewing;
	public AudioClip appleSound;
	public AudioClip bananaSound;
	public AudioClip pearSound;
	public AudioClip kiwiSound;
	public AudioClip grapeSound;
	public AudioClip orangeSound;

	SpeechRec speechRecognizer;




	void Start ()
	{
		mouth.GetComponent<SphereCollider> ();
		mouth.isTrigger = false;
		Chewing = GetComponent<AudioSource>();
		FruitSounds = new AudioClip[6];

		// assign the second element
		FruitSounds [0] = appleSound;
		FruitSounds [1] = bananaSound;
		FruitSounds [2] = pearSound;
		FruitSounds [3] = kiwiSound;
		FruitSounds [4] = grapeSound;
		FruitSounds [5] = orangeSound;

		speechRecognizer = SpeechRec.Instance;

	}
	void OnCollisionEnter(Collision fruit)
	{
		if (fruit.gameObject.tag == "apple") 
		{
			Chewing.clip = appleSound;
			Chewing.PlayOneShot (appleSound, 0.7f);
			fruit.gameObject.SetActive (false);


		} 

			else if (fruit.gameObject.tag == "banana") {
				Chewing.clip = bananaSound;
				Chewing.Play ();
				fruit.gameObject.SetActive (false);

			
			}
			
			else if (fruit.gameObject.tag == "pear") {
				Chewing.clip = pearSound;
				Chewing.Play ();
				fruit.gameObject.SetActive (false);

			
			}
			
			else if (fruit.gameObject.tag == "kiwi") {
				Chewing.clip = kiwiSound;
				Chewing.Play ();
				fruit.gameObject.SetActive (false);

			
			}
			
			else if (fruit.gameObject.tag == "orange") {
				Chewing.clip = orangeSound;
				Chewing.Play ();
				fruit.gameObject.SetActive (false);

			
			}
			
			else if (fruit.gameObject.tag == "grape") {
				Chewing.clip = grapeSound;
				Chewing.Play ();
				fruit.gameObject.SetActive (false);

			
			}
	}

	void OnTriggerEnter(Collider Son)
	{
		if (Son.gameObject.tag == "SpeechTrigger") 
		{
			speechRecognizer.StartKW();

		}
	}

	void OnTriggerExit(Collider Son)
	{
		if (Son.gameObject.tag == "SpeechTrigger") 
		{
			speechRecognizer.StopKW ();

		}
	}


}