using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparaBomba : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bombita;
    public int tiempoprueva = 25;
    public int cuentabombas = 3;
    //public int poer = 10;
    void Start()
    {
        InvokeRepeating("invbomba", 1, tiempoprueva * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void invbomba()
    {
      //  power = Random.Range(10, 100);
        GameObject esbomba = Instantiate(bombita, transform.position, transform.rotation);

        
    }
}