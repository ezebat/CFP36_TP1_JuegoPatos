using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejemploinstanciar : MonoBehaviour
{
    public GameObject prefab;
    public Transform ChePoint;
    //flag
    public bool SpawnFlag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward)&&SpawnFlag)
        {
            Debug.Log("se cumplio");
            Instantiate(prefab, ChePoint.position, transform.rotation);
            SpawnFlag = false;
            Destroy(transform.parent.gameObject);
        }
        
    }
}
