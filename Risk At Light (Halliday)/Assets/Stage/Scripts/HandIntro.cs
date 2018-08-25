using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandIntro : MonoBehaviour 
{

	public GameObject handPS;

	void Start ()
		{

		handPS.SetActive (false);

		}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "climbrock") 
		{
			handPS.SetActive (true);

		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "climbrock") 
		{
			handPS.SetActive (false);

		}
	}

}