using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Invoke("destruir", 1);
    }
    public void destruir()
    {
        Destroy(gameObject);
    }
}
