using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBomba : MonoBehaviour
{
    public int tiempo = 3;
    public int poder = 0;
    public int angulo = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destruirb", tiempo);
    }

    // Update is called once per frame
    void Update()
    {
        poder = Random.Range(1, 10);
        transform.Translate(0, (poder/100) * Time.deltaTime, poder * Time.deltaTime);
    }

    public void destruirb()
    {
        Destroy(gameObject);
    }
}
