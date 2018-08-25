using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
	
	public Transform player;
	public Transform respawnPoint;

	public GameObject platform1;
	public GameObject platform2;
	public GameObject platform3;

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player") 
		{
			platform1.SetActive (true);
			platform2.SetActive (true);
			platform3.SetActive (true);
			player.transform.position = respawnPoint.transform.position;
			Debug.Log ("playertriggered Respawn");
		}
	}

}

