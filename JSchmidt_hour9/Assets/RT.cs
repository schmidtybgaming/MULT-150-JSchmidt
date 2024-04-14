using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RT : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + "has entered right trigger");
    }
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + "is still in right trigger");
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + "has left right trigger");
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
