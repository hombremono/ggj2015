using UnityEngine;

public class TutoManager : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (GameObject.FindObjectsOfType<Pocion>().Length == 0)
			Application.LoadLevel("nivel1");
    }
}
