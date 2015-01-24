﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public float roundTime;
	private Tamago bicho;
	
	// Use this for initialization
	void Start () {
		roundTime = 10;
		bicho = GameObject.Find ("Bichito").GetComponent<Tamago>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (roundTime > 0) 
		{
			roundTime -= Time.deltaTime;
			GetComponent<Text> ().text = roundTime.ToString("00.00")+"'";
		}
		else 
		{
			bicho.Matar();
			GetComponent<Text> ().text = "muerto";
		}
		
		
	}
}
