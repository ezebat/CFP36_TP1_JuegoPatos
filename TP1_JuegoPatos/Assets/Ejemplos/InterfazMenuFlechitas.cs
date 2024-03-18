using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfazMenuFlechitas : MonoBehaviour
{
    public List<GameObject> patos;
    public int flag;
    public GameObject piso;
    public GameObject pato;
    public GameObject[,] matrizinha;
    // Start is called before the first frame update
    void Start()
    {
        matrizinha =  new GameObject[10, 10];
        print("soy: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            flag--;
            flag = flag % patos.Count;

            SwitchOff();
            patos[flag].SetActive(true);
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (flag==0)
            {
                piso.SetActive(false);
            }
            if (flag==1)
            {
                
            }
        }
    }
    public void SwitchOff ()
    {
        foreach ( GameObject pato in patos)
        {
            pato.SetActive(false);
        }
    }
}
