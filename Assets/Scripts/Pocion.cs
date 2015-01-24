﻿using UnityEngine;
using System.Collections;

public class Pocion : MonoBehaviour {

	public Stats stat;
	public string NOMBRE_AGREGAR_POCION;
	public string NOMBRE_PROBETA;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnLeftClick(){
		Debug.Log("Pressed left click on pota.");
		var obj1 = GameObject.Find (NOMBRE_PROBETA);
		obj1.SendMessage (NOMBRE_AGREGAR_POCION, stat);
	}

	void OnRightClick(){
		Debug.Log("Pressed right click on pota.");
	}

	void OnMouseEnter()
	{
		anim.SetBool ("Animacion",true);
	}
	void OnMouseExit()
	{
		anim.SetBool ("Animacion",false);
	}
}

public enum Stats {
	Fuerza,
	Destreza,
	Inteligencia,
	Carisma,
	Suerte
}