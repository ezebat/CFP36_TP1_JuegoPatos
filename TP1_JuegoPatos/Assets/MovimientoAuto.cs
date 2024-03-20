using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAuto : MonoBehaviour
{

    public int movilidad = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, movilidad * Time.deltaTime, 0);
    }
}
