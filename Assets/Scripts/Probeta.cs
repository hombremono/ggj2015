using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Probeta : MonoBehaviour
{


		private int EstadoActual;
		private int fuerza;
		private int destreza;
		private int inteligencia;
		private int suerte;
		private int carisma;
		public string NOMBRE_TAMAGO;
		public string NOMBRE_TOMAR_POCION;


		// Use this for initialization
		void Start ()
		{
				Vaciar ();
		}
	
		// Update is called once per frame
		void Update ()
		{
		if (EstadoActual >= 5) {
			Debug.Log ("Tomar pota.");
			var obj1 = GameObject.Find (NOMBRE_TAMAGO);
			obj1.SendMessage (NOMBRE_TOMAR_POCION, ArmarArray ());
			Vaciar ();
		}

		}

		public void AgregarPota (Stats stat)
		{
				if (EstadoActual < 5) {
						Debug.Log ("pota agregada");
						if (stat == Stats.Fuerza) {
								fuerza++;
								EstadoActual++;
								transform.Find ("relleno" + EstadoActual).GetComponent<SpriteRenderer> ().color = new Color (0.84f, 0.17f, 0.3f, 1f);
						}
			
						if (stat == Stats.Destreza) {
								destreza++;
								EstadoActual++;
								transform.Find ("relleno" + EstadoActual).GetComponent<SpriteRenderer> ().color = new Color (0.74f, 0.36f, 0.82f, 1f);
				
						}
						if (stat == Stats.Inteligencia) {
								inteligencia++;
								EstadoActual++;
								transform.Find ("relleno" + EstadoActual).GetComponent<SpriteRenderer> ().color = new Color (0.46f, 0.62f, 0.84f, 1f);
						}
						if (stat == Stats.Suerte) {
								suerte++;
								EstadoActual++;
								transform.Find ("relleno" + EstadoActual).GetComponent<SpriteRenderer> ().color = new Color (0.74f, 0.93f, 0.14f, 1f);
						}
						if (stat == Stats.Carisma) {
								carisma++;
								EstadoActual++;
								transform.Find ("relleno" + EstadoActual).GetComponent<SpriteRenderer> ().color = new Color (1f, 0.7f, 0.2f, 1f);
						}
			
				}

		}

		private int[] ArmarArray ()
		{
				int[] arr = new int[5];
				arr [0] = fuerza;
				arr [1] = destreza;
				arr [2] = inteligencia;
				arr [3] = carisma;
				arr [4] = suerte;
				return arr;
		}

		private void Vaciar ()
		{
				EstadoActual = 0;

				fuerza = 0;
				destreza = 0;
				inteligencia = 0;
				suerte = 0;
				carisma = 0;
				
				transform.Find ("relleno1").GetComponent<SpriteRenderer> ().color = new Color (1f, 0.7f, 0.2f, 0f);
				transform.Find ("relleno2").GetComponent<SpriteRenderer> ().color = new Color (1f, 0.7f, 0.2f, 0f);
				transform.Find ("relleno3").GetComponent<SpriteRenderer> ().color = new Color (1f, 0.7f, 0.2f, 0f);
				transform.Find ("relleno4").GetComponent<SpriteRenderer> ().color = new Color (1f, 0.7f, 0.2f, 0f);
				transform.Find ("relleno5").GetComponent<SpriteRenderer> ().color = new Color (1f, 0.7f, 0.2f, 0f);
		}
}
