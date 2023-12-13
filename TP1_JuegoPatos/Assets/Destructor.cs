using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Destructor : MonoBehaviour
{
    public int tiempoMecha = 2;
    public float radius = 3;
    public LayerMask layers;
    public float puntaje;
    public TextMeshProUGUI puntajepato;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Invoke("destruir", tiempoMecha);
    }
    public void destruir()
    {
        Destroy(gameObject);

        Collider[] cols = Physics.OverlapSphere(transform.position, radius, layers);

        GameObject closestG = gameObject;


        foreach (Collider c in cols)
        {
            //c.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            float distance = Vector3.Distance(transform.position,
                c.ClosestPoint(transform.position));

            float daño = 100;
            float distancia = distance - 2; //aca es la distancia minima para el maximo daño
            if (distancia < 1) distancia = 1; //aca paraque no sea distancia negativa
            if (distancia > 100) distancia = 100; //distancia maxima dada

            float multiplicador = 0;
            multiplicador = 100 / distancia;
            float auxiliar = multiplicador;
            daño = daño * (auxiliar / 100);



           // if (c.gameObject.GetComponent<Life>() != null)
            {
              // c.gameObject.GetComponent<Renderer>().material.color = Color.red;

                Vector3 ray = transform.position;
                Vector3 ray2 = c.transform.position - transform.position;
                RaycastHit hit;
                if (Physics.Raycast(ray, ray2, out hit, 1000000f, layers))
                {
                    // El clic ha golpeado un objeto
                    //print (hit.collider.gameObject.name);
                    GameObject objetoGolpeado = hit.collider.gameObject;
                    GameObject objetoQueGolpea = this.gameObject;  // Este objeto, el que contiene el script

                    Destroy(objetoGolpeado.GetComponent<cambiarcabeza>().cabeza);
                    Destroy(objetoGolpeado.GetComponent<cambiarcabeza>().cuerpo);
                    Destroy(objetoGolpeado.GetComponent<cambiarcabeza>().pico);

                    //puntaje = puntaje + objetoGolpeado.GetComponent<Puntajeybomba>().puntaje;

                    if (objetoGolpeado.GetComponent<Puntajeybomba>() != null)
                    {
                        objetoGolpeado.GetComponent<Puntajeybomba>().explotado();
                        //puntajepato.text = puntaje.ToString();
                    }
                }
            
        }
        
    }
    }
}
