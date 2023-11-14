using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public LayerMask layer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
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

            }
        }
    }
}
    