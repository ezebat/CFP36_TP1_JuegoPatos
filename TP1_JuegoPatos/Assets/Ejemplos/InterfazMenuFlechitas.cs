using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfazMenuFlechitas : MonoBehaviour
{
    public List<GameObject> patos;
    public int flag;
    public GameObject piso;
    public GameObject pato;
    public GameObject ezquina;

    // Start is called before the first frame update
    void Start()
    {
      
        print("soy: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            flag--;
            flag = flag % patos.Count;
         //4/3=1 5/3=1 6/3=2

            SwitchOff();
            patos[Mathf.Abs(flag)].SetActive(true);
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (flag==0)
            {
                piso.SetActive(false);
            }
            if (Mathf.Abs(flag) == 1)
            {
                pato.transform.position = ezquina.transform.position;
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
