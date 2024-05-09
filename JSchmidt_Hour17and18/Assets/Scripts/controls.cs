using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
        
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("Color");
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger("Scale");
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("Rotation");
        }

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("Position");
        }
    }
}
