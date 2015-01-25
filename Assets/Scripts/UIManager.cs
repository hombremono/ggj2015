using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Application.loadedLevelName == "tuto" && FindObjectsOfType<Pocion>().Length == 0)
            Application.LoadLevel("nivel1");
    }


	public void StartGame()
	{
		Application.LoadLevel("tuto");
	}

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Nivel1()
    {
        Application.LoadLevel("nivel1");
    }

    public void Menu()
    {
        Application.LoadLevel("menu");
    }
}
