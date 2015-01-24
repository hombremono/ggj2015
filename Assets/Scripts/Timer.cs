using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public float roundTime;
	
	// Use this for initialization
	void Start () {
		roundTime = 10;
		
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
			GetComponent<Text> ().text = "muerto";
		}
		
		
	}
}
