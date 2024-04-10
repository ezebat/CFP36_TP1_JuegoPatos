using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int tiempo = 10;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destruir", tiempo);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void destruir()
    {
        Destroy(gameObject);
    }

}
