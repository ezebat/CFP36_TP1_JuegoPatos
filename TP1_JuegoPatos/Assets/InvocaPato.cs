using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvocaPato : MonoBehaviour
{
    public GameObject patito;
    public int tiempocreacion = 25;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("crear", 1, tiempocreacion * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void crear()
    {
        float especial = Random.Range(0, 10);
        

        GameObject espato = Instantiate(patito, transform.position, transform.rotation);

        if (especial > 5) {
            espato.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
         

            espato.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f);
            espato.GetComponent<cambiarcabeza>().cabeza.GetComponent<Renderer>().material.color = espato.GetComponent<Renderer>().material.color;
            espato.GetComponent<Puntajeybomba>().bomba = true;
            espato.GetComponent<Puntajeybomba>().puntaje = 200;
            espato.GetComponent<Puntajeybomba>().pcabeza = 500;
            espato.GetComponent<cambiarcabeza>().cabeza.GetComponent<Puntajeybomba>().bomba = true;
            espato.GetComponent<cambiarcabeza>().cabeza.GetComponent<Puntajeybomba>().puntaje = 200;
            espato.GetComponent<cambiarcabeza>().cabeza.GetComponent<Puntajeybomba>().pcabeza = 500;
        }




    }
}
