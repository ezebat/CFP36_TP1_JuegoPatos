using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject disparadorray;
    public LayerMask layer;
    public int cooldown = 3;
    float auxreloj = 0;
    public float puntaje = 0;
    public int bombas = 3;

    //para la bomba
    public GameObject bombita;
    public GameObject disparadorbomba;
    public int tiempoprueva = 25;
    public int cuentabombas = 2;
    float impulso = 0;
    float auximpulso = 0;

    public float tiempomax = 5;
    public float distanciamin = 10;
    public float distanciamax = 1000;

    //fin bomba
   // public TextMeshProUGUI puntajepato;
    public TextMeshProUGUI cuentabomba;
    public Image impulsometro;
    public bool bombaimplso = false;
    public Image balaLista;



    // Start is called before the first frame update
    void Start()
    {
        //puntajepato.text = puntaje.ToString();
        cuentabomba.text = bombas.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        print (Puntajes.puntaje);
        balaLista.fillAmount = 1- ((auxreloj - Time.time) / cooldown);
        if (bombaimplso == true) 
        { 
        impulsometro.fillAmount = (Time.time - auximpulso)/tiempomax;
        }
        //script disparo
        //Debug.DrawLine(disparadorray.transform.position, (disparadorray.transform.forward * 1000000) + disparadorray.transform.position, Color.red);
        if (Time.time > auxreloj)
        {
            if (Input.GetMouseButtonDown(0))
            {
                auxreloj = Time.time + cooldown;
                //print(auxreloj);
                // Se ha hecho clic izquierdo
                //Vector3 mousePosition = Input.mousePosition;
                //Ray ray = Camera.main.ScreenPointToRay(mousePosition);
                //Ray ray = new(transform.position, disparadorray.transform.forward);
                
                Vector3 ray = disparadorray.transform.position;
                Vector3 ray2 = disparadorray.transform.forward;
                RaycastHit hit;


                if (Physics.Raycast(ray,ray2, out hit,1000000f,layer))
                {
                    // El clic ha golpeado un objeto
                    //print (hit.collider.gameObject.name);
                    GameObject objetoGolpeado = hit.collider.gameObject;
                    GameObject objetoQueGolpea = this.gameObject;  // Este objeto, el que contiene el script

                    //Debug.Log("Clic izquierdo detectado en el objeto: " + objetoGolpeado.name);
                    //Debug.Log("Objeto que golpea: " + objetoQueGolpea.name);

                    // Destruye el objeto golpeado

                    Destroy(objetoGolpeado.GetComponent<cambiarcabeza>().cabeza);
                    Destroy(objetoGolpeado.GetComponent<cambiarcabeza>().cuerpo);
                    Destroy(objetoGolpeado.GetComponent<cambiarcabeza>().pico);

                    if (objetoGolpeado.GetComponent<Puntajeybomba>().bomba == true)
                    {
                        bombas = bombas + 1;
                        cuentabomba.text = bombas.ToString();
                    }
                    
                    if (objetoGolpeado.GetComponent<Puntajeybomba>() != null)
                    {
                        objetoGolpeado.GetComponent<Puntajeybomba>().Disparame();
                        //puntajepato.text = puntaje.ToString();
                    }
                }
            }
        }

        //script bomba
        if (Input.GetMouseButtonDown(1))
        {
            auximpulso = Time.time;
            if (bombas > 0)
            {
                bombaimplso = true;
            }
        }
        if (Input.GetMouseButtonUp(1))
        {
            bombaimplso = false;
            impulsometro.fillAmount = 0;
            if (bombas > 0)
            {
                impulso = (Time.time - auximpulso);
                if (impulso > tiempomax) 
                {
                    impulso = tiempomax;
                }
                impulso = (impulso * distanciamax) + distanciamin;
                //print(impulso);

                //float potenciafinal = impulso * 3;
                GameObject bombitax = Instantiate(bombita, transform.position, transform.rotation);
                bombitax.GetComponent<Rigidbody>().AddForce((disparadorbomba.transform.forward * impulso)+ ((disparadorbomba.transform.up * impulso)));
                bombas = bombas - 1;
                cuentabomba.text = bombas.ToString();
                bombaimplso = false;

            }
            
        }
    }
}



    