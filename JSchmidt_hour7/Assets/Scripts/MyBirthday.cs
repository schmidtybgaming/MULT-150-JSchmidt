using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int month = 1; month <= 12; month++)
            if (month == 11)
        {
                print("It's my birthday!"); Debug.Log(month);
        }
        
       
        for (int day = 1; day <= 31; day++)
       if (day == 27)
        {
                print("It's my birthday!"); Debug.Log(day);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
