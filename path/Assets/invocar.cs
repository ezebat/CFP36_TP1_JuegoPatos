using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invocar : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float tiempocreacion = 5f;
    public GameObject Invocacion;
    

    void Start()
    {
        Invoke("crear", tiempocreacion);
    }

    // Update is called once per frame
    void Update()
    {
                  
    }
    private void Awake()
    {
        
    }
    void crear()
    {
         
        GameObject Creado = Instantiate(Invocacion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
