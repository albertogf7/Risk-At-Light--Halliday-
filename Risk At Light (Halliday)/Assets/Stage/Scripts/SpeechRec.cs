using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Collections;

public class SpeechRec : MonoBehaviour
{



	[SerializeField]
	private string[] m_Keywords;

	private KeywordRecognizer m_Recognizer;
	public GameObject manzana;
	public GameObject pera;
	public GameObject platano;
	public GameObject kiwi;
	public GameObject uva;
	public GameObject naranja;

	//fruit spawners

	public Transform applePosition;
	public Transform pearPosition;
	public Transform bananaPosition;
	public Transform orangePosition;
	public Transform kiwiPosition;
	public Transform grapePosition;
	ObjectPooler objectPooler;

	#region Singleton
	public static SpeechRec Instance;

	private void Awake()
	{
		Instance = this;
	}
	#endregion

	void Start()
	{
		m_Keywords = new string[6];
		m_Keywords[0] = "la manzana";
		m_Keywords[1] = "la pera";
		m_Keywords[2] = "el platano";
		m_Keywords[3] = "el kiwi";
		m_Keywords[4] = "la uva";
		m_Keywords[5] = "la naranha";
	


		m_Recognizer = new KeywordRecognizer(m_Keywords);
		m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;


		manzana.SetActive (false);
		pera.SetActive (false);
		platano.SetActive (false);
		kiwi.SetActive (false);
		uva.SetActive (false);
		naranja.SetActive (false);

		objectPooler = ObjectPooler.Instance;

	}

	private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
	{


			 if (args.text == m_Keywords[0])
		{
			objectPooler.SpawnFromPool ("apple", applePosition.position, Quaternion.identity);
			manzana.SetActive(true);


		} 

		else if (args.text == m_Keywords[1])
		{
			objectPooler.SpawnFromPool ("pear", pearPosition.position, Quaternion.identity);
			pera.SetActive (true);
		
		} 

		else if (args.text == m_Keywords[2])
		{
			objectPooler.SpawnFromPool ("banana", bananaPosition.position, Quaternion.identity);
			platano.SetActive (true);
		
		} 

		else if (args.text == m_Keywords[3])
		{
			objectPooler.SpawnFromPool ("kiwi", kiwiPosition.position, Quaternion.identity);
			kiwi.SetActive (true);
		
		} 

		else if (args.text == m_Keywords[4])
		{
			objectPooler.SpawnFromPool ("grape", grapePosition.position, Quaternion.identity);
			uva.SetActive (true);
		
		} 

		else if (args.text == m_Keywords[5])
		{
			objectPooler.SpawnFromPool ("orange", orangePosition.position, Quaternion.identity);
			naranja.SetActive (true);

		}
	}﻿

	public void StartKW()
	{
		m_Recognizer.Start();
	}

	public void DisposeKW()
	{
		m_Recognizer.Dispose();
	}
	public void StopKW()
	{
		m_Recognizer.Stop();
	}
}