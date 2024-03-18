using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCC : MonoBehaviour
{
    public float HSpeed;
    private CharacterController CC;
    public Vector3 gravity;
    public float JumpForce;
    public Vector3 VerticalForce;
    public int[,] matriz;
    public InterfazMenuFlechitas matrix;
    public Vector2 direccion;
    public Transform jetpackDir;
    public float JetpackForce;
    // Start is called before the first frame update
    void Start()
    {
       
     
        CC = GetComponent<CharacterController>();
         
     
    }

    // Update is called once per frame
    void Update()
    {
        if (CC.isGrounded)
        {
            VerticalForce = new Vector3(0, 0, 0);
        }
        Vector3 movement;
        movement = new Vector3(0, 0, 0);
        movement += new Vector3(0, 0, HSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
        ///////////////////////////////ParaSaltos//////////////////////////////////////////
        VerticalForce += gravity*Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CC.isGrounded)
            VerticalForce  = new Vector3(0, JumpForce, 0);
           
            
        }
        if (!CC.isGrounded&& Input.GetKey(KeyCode.Space))
        {
            //jetpack
            VerticalForce += JetpackForce * Time.deltaTime * jetpackDir.forward;
        }
        ////////////////////////////////////////////////////////////////////////////////////
        movement += VerticalForce;
        CC.Move(movement*Time.deltaTime);

        if (VerticalForce.y<=0)
        {
            Debug.Log(transform.position.y);
        }
    }
}