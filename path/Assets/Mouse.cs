using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent nav;
    public float velocidad = 4;
    float vel;
    float auxreloj =1;
    public float cooldown = 4;

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
        if (Time.time > auxreloj)
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
            auxreloj = Time.time + cooldown;
            vel = velocidad;
        }
        else vel = 1;
            
        nav.speed = 3.5f * vel;
         
        }
        }
}




