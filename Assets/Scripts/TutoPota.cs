using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutoPota : MonoBehaviour {

	float distanceToAnim;
	float startTime;
    float distanceToLeave;
    float finishAnimTime;
    public float animTime;
	public Vector3 startPosition;
	public Vector3 animPosition;
	public Vector3 endPosition;
	public float speed;
	GameObject pota;
    Text[] displayText;
    public string DISPLAY_TEXT;

	// Use this for initialization
	void Start () {
		pota = this.gameObject;
	    displayText = GameObject.Find("Canvas").GetComponentsInChildren<Text>();
		startTime = Time.time;
		finishAnimTime = 0f;
		pota.transform.position = startPosition;
		distanceToAnim = Vector3.Distance (startPosition, animPosition);
	    distanceToLeave = Vector3.Distance(animPosition, endPosition);
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (animTime > 0f)
	    {
			pota.SendMessage("SetAnimacion", false);
            float distanceCovered = (Time.time - startTime) * speed;
            float fracJourney = distanceCovered / distanceToAnim;
            pota.transform.position = Vector3.Lerp(startPosition, animPosition, fracJourney);
            if (pota.transform.position.Equals(animPosition))
            {
                foreach (var t in displayText)
                {
                    if (t.name == DISPLAY_TEXT)
                    {
                        t.transform.position = pota.transform.position;
                        t.text = GetComponent<Pocion>().GetStat().ToString();
                        break;
                    }
                }

				pota.SendMessage("SetAnimacion", true);
				animTime -= Time.deltaTime;
            }
	    }
        else
        {
            foreach (var t in displayText)
            {
                if (t.name == DISPLAY_TEXT)
                {
                    t.text = "";
                    break;
                }
            }
			pota.SendMessage("SetAnimacion", false);
			if (finishAnimTime == 0f)
			{
				finishAnimTime = Time.time;
			}
			float distanceCovered = (Time.time - finishAnimTime) * speed;
            float fracJourney = distanceCovered / distanceToLeave;
            pota.transform.position = Vector3.Lerp(animPosition, endPosition, fracJourney);
        }
	    if (pota.transform.position.Equals(endPosition))
	    {
			Destroy (this.gameObject);
	    }
	}
}
