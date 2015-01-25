using UnityEngine;
using System.Collections;

public class RetryButton : MonoBehaviour {

	public Sprite normalSprite;
	public Sprite pressedSprite;
	float distance;
	float startTime;
	Vector3 startPosition;
	public Vector3 endPosition;
	public float speed;
	GameObject retryButton;
	bool mostrar;


	// Use this for initialization
	void Start () {
		mostrar = false;
		retryButton = this.gameObject;
		startPosition = retryButton.transform.position;

		distance = Vector3.Distance (startPosition, endPosition);
	}
	
	// Update is called once per frame
	void Update () {
		if (mostrar) {
			// mover hasta endPosition
			float distanceCovered = (Time.time - startTime) * speed;
			float fracJourney = distanceCovered / distance;
			retryButton.transform.position = Vector3.Lerp(startPosition, endPosition, fracJourney);
		}

	}

	void OnLeftClick(){

		retryButton.GetComponent<SpriteRenderer> ().sprite = pressedSprite;
		Application.LoadLevel("nivel1");
	}
	
	void OnRightClick(){

	}
	
	void OnMouseEnter()	{

	}

	void OnMouseExit()	{

		retryButton.GetComponent<SpriteRenderer> ().sprite = normalSprite;
	}

	void Mostrar(bool b) {
		mostrar = b;
		startTime = Time.time;
	}
}
