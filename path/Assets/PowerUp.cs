using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.AI;


public class PowerUp : MonoBehaviour
{
    public float velocidadmax = 15f;
    public GameObject Invocador;
    public GameObject yo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                      

    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<NavMeshAgent>().speed = velocidadmax;
        other.gameObject.GetComponent<Mouse>().powerUp();
        GameObject Creado = Instantiate(Invocador, transform.position, transform.rotation);
        Creado.GetComponent<invocar>().Invocacion = (GameObject)yo;
        Destroy(gameObject);
    }

}
