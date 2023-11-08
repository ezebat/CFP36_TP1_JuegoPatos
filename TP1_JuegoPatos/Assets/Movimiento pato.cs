using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientopato : MonoBehaviour
{
    public int tiempo = 3;
    public int velocidad = 10;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destruir", tiempo);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, velocidad * Time.deltaTime);
    }

    public void destruir()
    {
        Destroy(gameObject);
    }
}
