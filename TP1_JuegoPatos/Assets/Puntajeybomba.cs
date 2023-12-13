using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntajeybomba : MonoBehaviour
{
    public bool bomba = false;
    public float puntaje = 100;
    public float puntajeBomba = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Disparame()
    {
        Puntajes.puntaje += puntaje;
    }
    public void explotado()
    {
        Puntajes.puntaje += puntajeBomba;
    }
}
