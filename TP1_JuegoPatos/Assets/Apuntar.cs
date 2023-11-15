using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntar : MonoBehaviour
{
    public GameObject apuntocuerpo;
    public GameObject apuntocamara;
    public int speed = 100;
    // Start is called before the first frame update
    void Start()
    {
        apuntocuerpo.GetComponent<Renderer>().transform.Rotate(0, 0, 0);
        apuntocamara.GetComponent<Renderer>().transform.Rotate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(speed * Time.deltaTime * Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X") * speed * Time.deltaTime, 0);
        apuntocuerpo.GetComponent<Renderer>().transform.Rotate(0, Input.GetAxis("Mouse X") * speed * Time.deltaTime, 0);
        apuntocamara.GetComponent<Renderer>().transform.Rotate(speed * Time.deltaTime * Input.GetAxis("Mouse Y"), 0, 0);

    }
}
