using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;


public class Personaje : MonoBehaviour
{
    public NavMeshAgent nav;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.SetDestination(target.position);
    }
}
