using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
            this.GetComponent<Light>().enabled = false;
        if (Input.GetKey(KeyCode.O))
            this.GetComponent<Light>().enabled = true;

    }
}
