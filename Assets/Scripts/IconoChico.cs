using UnityEngine;
using System.Collections;

public class IconoChico : MonoBehaviour {

	public string BigIconName;
	public bool Pressed;
	Animator anim;

	// Use this for initialization
	void Start () {
		Pressed = false;
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Pressed) 
		{
			anim.SetBool("Apretado",true);
			Debug.Log ("apretado");

		}

	
	}

	void OnLeftClick()
	{
		anim.SetTrigger ("Apretar");
		var iconos = GameObject.Find ("IconosGrandes");
		foreach (var item in iconos.GetComponentsInChildren<Transform>()) 
		{
			if (item.name != "IconosGrandes") 
			{
				Debug.Log(item.name);
				GameObject.Find (item.name).GetComponent<SpriteRenderer> ().color = new Color (1f,1f,1f,0f);
				
			}

		}
		Debug.Log("Pressed left click on icono chico.");
		GameObject.Find (BigIconName).GetComponent<SpriteRenderer> ().color = new Color (1f,1f,1f,1f);



	}
}
