using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCmove : MonoBehaviour
{
    CharacterController CC;
    public float speed;
    public Vector3 gravedad;
   public  Vector3 verticalMovement;
    public Transform objetivo;
    public Vector3 gravedadauxiliar;
    public Vector3 fuerzaSalto;

    // Start is called before the first frame update
    void Start()
    {
        CC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*   gravedadauxiliar = new Vector3(0, 0, 0);
           gravedadauxiliar = objetivo.position - transform.position;
           gravedadauxiliar = Vector3.Normalize(gravedadauxiliar);
           gravedadauxiliar *= 9.8f * Time.deltaTime;
           verticalMovement += gravedadauxiliar;*/



        


        if (CC.isGrounded)
        {
            verticalMovement = new Vector3(0, 0, 0);
            GetComponent<Animator>().SetBool("piso", false);
        }
        verticalMovement += gravedad * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && CC.isGrounded)
        {
            verticalMovement = fuerzaSalto;
            GetComponent<Animator>().SetBool("piso", true);
        }
        Vector3 movement = new Vector3(0,0,0);
        movement += transform.forward * speed  * Input.GetAxis("Vertical");
        movement += transform.right * speed  * Input.GetAxis("Horizontal");


        GetComponent<Animator>().SetFloat("corriendo", Input.GetAxis("Vertical"));
        GetComponent<Animator>().SetFloat("lados", Input.GetAxis("Horizontal"));


        movement += verticalMovement;
        CC.Move(movement*Time.deltaTime);
    }
}
