using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    int count = 1;
    
    
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + "int count");
    }
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name);
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
          
    }
}
