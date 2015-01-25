using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public float roundTime;
	private Tamago bicho;
	
	// Use this for initialization
	void Start () {
		roundTime = 10;

		bicho = GameObject.Find ("Tamago").GetComponent<Tamago> ();		
	}
	
	// Update is called once per frame
	void Update () {
		if (roundTime > 0 && !bicho.Exito && bicho.GetForma() != "Muerto") 
		{
			roundTime -= Time.deltaTime;
			GetComponent<Text> ().text = roundTime.ToString("00.00")+"'";
		}
		else 
		{
			if (bicho.Exito) 
			{
				GetComponent<Text> ().text = "UP!";
			}
			else 
			{
				bicho.Matar();
				GetComponent<Text> ().text = "00:00";
			}

		}
		
		
	}
}
