using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int m = 1; m <= 12; m++)
            
        {
                Debug.Log(m);
        }
      
       
           
        for (int d = 1; d <= 31; d++)
       
        {
                Debug.Log(d);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
