using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LT : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + "has entered left trigger");
    }
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + "is still in left trigger");
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + "has left left trigger");
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
