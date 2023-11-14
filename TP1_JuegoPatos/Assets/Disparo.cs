using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class NewBehaviourScript : MonoBehaviour
{
    public LayerMask layer;
    public int cooldown = 3;
    float auxreloj = 0;
    public float puntaje = 0;
    public int bombas = 3;

    //para la bomba
    public GameObject bombita;
    public int tiempoprueva = 25;
    public int cuentabombas = 3;
    float impulso = 0;
    float auximpulso = 0;

    public float tiempomax = 5;
    public float distanciamin = 10;
    public float distanciamax = 1000;

    //fin bomba


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //script disparo
        if (Time.time > auxreloj)
        {
            if (Input.GetMouseButtonDown(0))
            {
                auxreloj = Time.time + cooldown;
                print(auxreloj);
                // Se ha hecho clic izquierdo
                Vector3 mousePosition = Input.mousePosition;
                Ray ray = Camera.main.ScreenPointToRay(mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100f, layer))
                {
                    // El clic ha golpeado un objeto
                    GameObject objetoGolpeado = hit.collider.gameObject;
                    GameObject objetoQueGolpea = this.gameObject;  // Este objeto, el que contiene el script

                    Debug.Log("Clic izquierdo detectado en el objeto: " + objetoGolpeado.name);
                    Debug.Log("Objeto que golpea: " + objetoQueGolpea.name);

                    // Destruye el objeto golpeado

                    Destroy(objetoGolpeado.GetComponent<cambiarcabeza>().cabeza);
                    Destroy(objetoGolpeado.GetComponent<cambiarcabeza>().cuerpo);
                    Destroy(objetoGolpeado.GetComponent<cambiarcabeza>().pico);

                    if (objetoGolpeado.GetComponent<Puntajeybomba>().bomba == true)
                    {
                        bombas = bombas + 1;
                        print(bombas);
                    }
                    puntaje = puntaje + objetoGolpeado.GetComponent<Puntajeybomba>().puntaje;
                    print(puntaje);

                }
            }
        }

        //script bomba
        if (Input.GetMouseButtonDown(1))
        {
            auximpulso = Time.time;
        }
        if (Input.GetMouseButtonUp(1))
        { 
            if (bombas > 0)
            {
                impulso = (Time.time - auximpulso);
                if (impulso > 5) 
                {
                    impulso = 5;
                }

                print(impulso);
                
                GameObject esbomba = Instantiate(bombita, transform.position, transform.rotation);
                bombas = bombas - 1;
                print(bombas);
            }
        }
    }
}

    