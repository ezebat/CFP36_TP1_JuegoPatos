using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
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

            if (Physics.Raycast(ray, out hit))
            {
                // El clic ha golpeado un objeto
                GameObject objetoGolpeado = hit.collider.gameObject;
                if (objetoGolpeado.CompareTag("Objetivo"))
                {
                    // Destruye el objeto
                    Destroy(objetoGolpeado);
                    Debug.Log("Clic izquierdo destruyó el objeto: " + objetoGolpeado.name);
                }
                   
            }
        }
    }
}
    