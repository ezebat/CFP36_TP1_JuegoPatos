using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent nav;
    public float velocidadnorm = 4;
    public float tiempovolver = 4f;
  

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            nav.SetDestination(hit.point);

        }
       }
    public void powerUp()
    {
        Invoke("normal", tiempovolver);
    }
    void normal()
    {
        
        nav.GetComponent<NavMeshAgent>().speed = velocidadnorm;
    }
}




