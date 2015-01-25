using UnityEngine;
using System.Collections;

public class Tamago : MonoBehaviour {

	private int fuerza;
	private int destreza;
	private int inteligencia;
	private int carisma;
	private int suerte;
	private Formas forma; 
	Animator relleno;
	Animator trazo;
	Animator contorno;
	Animator nuevorelleno;
	public bool Exito;
	bool pidioBoton;
    private Color colorActual;

	// Use this for initialization
	void Start () {
		fuerza = 0;
		destreza = 0;
		inteligencia = 0;
		carisma = 0;
		suerte = 0;
		forma = Formas.Inicial;
		relleno = transform.Find ("Relleno").GetComponent<Animator>();
		trazo = transform.Find ("Trazo").GetComponent<Animator> ();
		contorno = transform.Find ("Contorno").GetComponent<Animator> ();
		nuevorelleno = transform.Find ("NuevoRelleno").GetComponent<Animator> ();
		Exito = false;
		pidioBoton = false;
	    colorActual = Color.blue;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    transform.Find("Relleno").GetComponent<SpriteRenderer>().color = colorActual;
		if (forma == Formas.Muerto) {
			Debug.Log("muerto update");
			relleno.SetTrigger ("Morir");
			contorno.SetTrigger ("Morir");
			trazo.SetTrigger ("Morir");
			if (!pidioBoton) {
				GameObject.Find ("RetryButton").SendMessage ("Mostrar", true);
				pidioBoton = true;
			}
            
		}
        nuevorelleno = transform.Find("NuevoRelleno").GetComponent<Animator>();

	    if (nuevorelleno.GetCurrentAnimatorStateInfo(0).normalizedTime == 1 && !nuevorelleno.IsInTransition(0))
	    {
	        Debug.Log("it works!");
	    }
	}

    public void CambiarColor(Color nuevoColor)
    {
        colorActual = nuevoColor;

    }

    void BeberPocion(int[] arr){
		fuerza = arr [0];
		destreza = arr [1];
		inteligencia = arr [2];
		carisma = arr [3];
		suerte = arr [4];
		forma = Transformar ();
	}

	public Formas Transformar(){
				if (fuerza == 1 && destreza == 2 && inteligencia == 2) 
				{
						relleno.SetTrigger ("Pintar");
						nuevorelleno.SetTrigger ("Pintar");
						contorno.SetTrigger ("Pintar");
						trazo.SetTrigger ("Pintar");
						Exito = true;
				    colorActual = Color.red;

                        return Formas.Cocinero;

				}

				else if (fuerza == 2 && inteligencia == 2 && suerte == 1)
				{
					relleno.SetTrigger ("Pintar");
					nuevorelleno.SetTrigger ("Pintar");
					contorno.SetTrigger ("Pintar");
					trazo.SetTrigger ("Pintar");
					Exito = true;
					return Formas.Bombero;

				}
				else if (destreza == 3 && inteligencia == 1 && carisma == 1)
				{
					relleno.SetTrigger ("Pintar");
					nuevorelleno.SetTrigger ("Pintar");
					contorno.SetTrigger ("Pintar");
					trazo.SetTrigger ("Pintar");
					Exito = true;
					return Formas.Modisto;
					
				}
				else if (fuerza == 2 && destreza == 2 && carisma == 1)
				{
					relleno.SetTrigger ("Pintar");
					nuevorelleno.SetTrigger ("Pintar");
					contorno.SetTrigger ("Pintar");
					trazo.SetTrigger ("Pintar");
					Exito = true;
					return Formas.Heroe;
					
				}
				else if (destreza == 3 && inteligencia == 1 && suerte == 1)
				{
					relleno.SetTrigger ("Pintar");
					nuevorelleno.SetTrigger ("Pintar");
					contorno.SetTrigger ("Pintar");
					trazo.SetTrigger ("Pintar");
					Exito = true;
					return Formas.Gamer;
				}
				else 
						return Formas.Muerto;
		}
	public string GetForma()
	{
		return forma.ToString ();
	}

	public void Matar(){
		forma = Formas.Muerto;
		Debug.Log("muerto matar");
		}
}

public enum Formas {
	Inicial,
	Cocinero,
	Gamer,
	Modisto,
	Bombero,
	Heroe,
	Muerto
}
