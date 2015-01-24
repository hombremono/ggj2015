using UnityEngine;
using System.Collections;

public class Tamago : MonoBehaviour {

	int fuerza;
	int destreza;
	int inteligencia;
	int carisma;
	int suerte;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
