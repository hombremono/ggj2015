using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Probeta : MonoBehaviour {


	private int EstadoActual;
	private int fuerza;   
	private int destreza;
	private int inteligencia;
	private int suerte;
	private int carisma;




	// Use this for initialization
	void Start () {
		EstadoActual = 0;
		//--------

		fuerza = 0;
		destreza = 0;
		inteligencia = 0;
		suerte = 0;
		carisma = 0;

		//----------




	}
	
	// Update is called once per frame
	void Update () {


	}

	public void AgregarPota (Stats stat)
	{
		if (EstadoActual < 5) 
		{
			Debug.Log ("pota agregada");
			if (stat == Stats.Fuerza)
			{
				fuerza++;
				EstadoActual++;
				transform.Find ("relleno" + EstadoActual).GetComponent<SpriteRenderer> ().color = new Color (0.84f,0.17f,0.3f,1f);
			}
			
			if (stat == Stats.Destreza) 
			{
				destreza++;
				EstadoActual++;
				transform.Find ("relleno" + EstadoActual).GetComponent<SpriteRenderer> ().color = new Color (0.74f,0.36f,0.82f,1f);
				
			}
			if (stat == Stats.Inteligencia) 
			{
				inteligencia++;
				EstadoActual++;
				transform.Find ("relleno" + EstadoActual).GetComponent<SpriteRenderer> ().color = new Color (0.46f,0.62f,0.84f,1f);
			}
			if (stat == Stats.Suerte) 
			{
				suerte++;
				EstadoActual++;
				transform.Find ("relleno" + EstadoActual).GetComponent<SpriteRenderer> ().color = new Color (0.74f,0.93f,0.14f,1f);
			}
			if (stat == Stats.Carisma) 
			{
				carisma++;
				EstadoActual++;
				transform.Find ("relleno" + EstadoActual).GetComponent<SpriteRenderer> ().color = new Color (1f,0.7f,0.2f,1f);
			}
			
		}

	}
}
