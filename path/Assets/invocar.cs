using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invocar : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int tiempocreacion = 10;
    public GameObject Invocar;
    int bandera = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bandera < 1)
            Debug.Log(bandera);
            
            InvokeRepeating("crear", 1, 1);
        
    }
    void crear()
    {
        GameObject Creado = Instantiate(Invocar, transform.position, transform.rotation);
        bandera = 2;
    }
}
