using UnityEngine;
using System.Collections;


public class Tamago : MonoBehaviour
{

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

    string item;
    public Formas formaGanadora;
    

    // Use this for initialization
    void Start()
    {
        fuerza = 0;
        destreza = 0;
        inteligencia = 0;
        carisma = 0;
        suerte = 0;
        forma = Formas.Inicial;
        relleno = transform.Find("Relleno").GetComponent<Animator>();
        trazo = transform.Find("Trazo").GetComponent<Animator>();
        contorno = transform.Find("Contorno").GetComponent<Animator>();
        nuevorelleno = transform.Find("NuevoRelleno").GetComponent<Animator>();
        Exito = false;
        pidioBoton = false;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (forma == Formas.Muerto)
        {
            Debug.Log("muerto update");
            relleno.SetTrigger("Morir");
            contorno.SetTrigger("Morir");
            trazo.SetTrigger("Morir");
            GameObject.Find("Problema").GetComponent<Animator>().SetTrigger("Loose");
            if (!pidioBoton && !Exito)
            {

                GameObject.Find("RetryButton").SendMessage("Mostrar", true);
                pidioBoton = true;
            }

        }
        else
        {
            if (forma.ToString() == formaGanadora.ToString())
            {
                GameObject.Find("Problema").GetComponent<Animator>().SetTrigger("Win");
                Exito = true;
            }
        }

    }



    void BeberPocion(int[] arr)
    {
        fuerza = arr[0];
        destreza = arr[1];
        inteligencia = arr[2];
        carisma = arr[3];
        suerte = arr[4];
        forma = Transformar();
    }

    public Formas Transformar()
    {
        if (destreza == 2 && inteligencia == 1 && carisma == 2)
        {
            nuevorelleno.GetComponent<SpriteRenderer>().color = new Color(0.67f, 0.82f, 0.29f, 1f);
            relleno.SetTrigger("Pintar");
            nuevorelleno.SetTrigger("Pintar");
            contorno.SetTrigger("Pintar");
            trazo.SetTrigger("Pintar");
            
            if (!string.IsNullOrEmpty(item) && item.Equals("BigCocinero"))
            {
                
                return Formas.Cocinero;
            }
            else
            {
                return Formas.Inicial;
            }

        }

        else if (fuerza == 2 && destreza == 1 && carisma == 1 && suerte == 1 )
        {
            nuevorelleno.GetComponent<SpriteRenderer>().color = new Color(0.46f, 0.63f, 0.8f, 1f);
            relleno.SetTrigger("Pintar");
            nuevorelleno.SetTrigger("Pintar");
            contorno.SetTrigger("Pintar");
            trazo.SetTrigger("Pintar");

            if (!string.IsNullOrEmpty(item) && item.Equals("BigBombero"))
            {
                //Exito = true;
                return Formas.Bombero;
            }
            else
            {
                return Formas.Inicial;
            }
            

        }
        else if (destreza == 3 && inteligencia == 1 && carisma == 1)
        {
            nuevorelleno.GetComponent<SpriteRenderer>().color = Color.yellow;
            relleno.SetTrigger("Pintar");
            nuevorelleno.SetTrigger("Pintar");
            contorno.SetTrigger("Pintar");
            trazo.SetTrigger("Pintar");
            if (!string.IsNullOrEmpty(item) && item.Equals("BigModisto"))
            {
                //Exito = true;
                return Formas.Modisto;
            }
            else
            {
                return Formas.Inicial;
            }
            

        }
        else if (fuerza == 2 && destreza == 2 && carisma == 1 )
        {
            nuevorelleno.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);
            relleno.SetTrigger("Pintar");
            nuevorelleno.SetTrigger("Pintar");
            contorno.SetTrigger("Pintar");
            trazo.SetTrigger("Pintar");
            if (!string.IsNullOrEmpty(item) && item.Equals("BigHero"))
            {
                //Exito = true;
                return Formas.Heroe;
            }
            else
            {
                return Formas.Inicial;
            }
            

        }
        else if (destreza == 3 && inteligencia == 1 && suerte == 1)
        {
            nuevorelleno.GetComponent<SpriteRenderer>().color = Color.cyan;
            relleno.SetTrigger("Pintar");
            nuevorelleno.SetTrigger("Pintar");
            contorno.SetTrigger("Pintar");
            trazo.SetTrigger("Pintar");
            if (  !string.IsNullOrEmpty(item) && item.Equals("BigGamer"))
            {
               // Exito = true;
                return Formas.Gamer;
            }
            else
            {
                return Formas.Inicial;
            }
            
        }
        else
        {
           // Exito = false;
            return Formas.Inicial;   
        }
    }
    public string GetForma()
    {
        return forma.ToString();
    }

    public void Matar()
    {
        forma = Formas.Muerto;
        //Debug.Log("muerto matar");
    }

    public void SetItem(string i)
    {
        Debug.Log(("SetItem: " + i));
        item = i;
    }
}

public enum Formas
{
    Inicial,
    Cocinero,
    Gamer,
    Modisto,
    Bombero,
    Heroe,
    Muerto
}
