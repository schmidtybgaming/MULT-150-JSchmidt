using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int e = 22; e < 101; e = e + 2)
            Debug.Log(e);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
