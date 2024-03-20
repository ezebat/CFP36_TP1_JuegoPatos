using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class MovimientoAuto : MonoBehaviour
{

    public int movilidad = 1;
    
    public GameObject auto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, movilidad * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(movilidad *-1 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(movilidad * Time.deltaTime, 0, 0);
        }
    }
}
