using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Created by : Ayran Olckers
 * 01/2020
 */
public class LevelPersistence : MonoBehaviour {

	private bool created = false;

	void Awake()
	{
		if (!created)
		{
			DontDestroyOnLoad(this.gameObject);
			created = true;
			// Debug.Log("Awake: " + this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
