using UnityEngine;
using System.Collections;

public class Tamago : MonoBehaviour {

	private int fuerza;
	private int destreza;
	private int inteligencia;
	private int carisma;
	private int suerte;
	public bool vivo;
	Animator anim;

	// Use this for initialization
	void Start () {
		fuerza = 0;
		destreza = 0;
		inteligencia = 0;
		carisma = 0;
		suerte = 0;
		vivo = true;
		anim = GetComponent<Animator> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		if (!vivo) 
		{
			anim.SetBool("AnimacionMuerte",true);
		}
	
	}

	void BeberPocion(int[] arr){
		fuerza = arr [0];
		destreza = arr [1];
		inteligencia = arr [2];
		carisma = arr [3];
		suerte = arr [4];
		Debug.Log (Transformar ());
	}

	public Formas Transformar(){
				if (fuerza == 1 && destreza == 2 && inteligencia == 2)
						return Formas.Cocinero;
				else if (fuerza == 2 && inteligencia == 2 && suerte == 1)
						return Formas.Bombero;
				else if (destreza == 3 && inteligencia == 1 && carisma == 1)
						return Formas.Modisto;
				else if (fuerza == 2 && destreza == 2 && carisma == 1)
						return Formas.Heroe;
				else if (destreza == 3 && inteligencia == 1 && suerte == 1)
						return Formas.Gamer;
				else 
						return Formas.Muerto;
		}
}

public enum Formas {
	Cocinero,
	Gamer,
	Modisto,
	Bombero,
	Heroe,
	Muerto
}
