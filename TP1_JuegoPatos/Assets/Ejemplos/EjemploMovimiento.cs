using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploMovimiento : MonoBehaviour
{
    private float velocidad;
    public float velocidadR;
    public float walkSpeed;
    public float sprintSpeed;
    // Start is called before the first frame update
    void Start()
    {
       
            
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            velocidad = sprintSpeed;
        else
            velocidad = walkSpeed;

       
            transform.Translate(0, 0, Time.deltaTime * velocidad * Input.GetAxis("Vertical"));
        transform.Rotate(0, velocidadR * Time.deltaTime* Input.GetAxis("Horizontal"), 0);
        
        
    }
}
