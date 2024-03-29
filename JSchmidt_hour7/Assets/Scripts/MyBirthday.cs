using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int month = 1; month <= 12; month++)
        {
            Debug.Log(month == 11);
        }
        print("It's my birthday!");
        for (int day = 1; day <= 31; day++)
        {
            Debug.Log(day == 27);
        }
        print("It's my birthday!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
