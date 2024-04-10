using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Generadorderuta : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Auto;
    public GameObject Ruta1;
    public GameObject Ruta2;
    public GameObject Ruta3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Auto.GetComponent<Transform>().position.z == 1) { }
        int ra = Random.Range(0, 3);

        if ( ra == 0)
            GameObject esRuta = Instantiate(Ruta1, transform.position + new Vector3(0, 0, 300), transform.rotation );
        if (ra == 1)
            GameObject esRuta = Instantiate(Ruta2, transform.position + new Vector3(0, 0, 300), transform.rotation );
        if (ra == 2)
            GameObject esRuta = Instantiate(Ruta3, transform.position + new Vector3(0, 0, 300), transform.rotation );
    }
}
