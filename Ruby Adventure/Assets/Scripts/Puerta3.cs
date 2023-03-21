using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta3 : MonoBehaviour
{
    

    public bool isOpen;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Open()
    {
        isOpen = true;
        animator.SetBool("IsOpen", isOpen);
    }

    public void Close()
    {
        isOpen = false;
        animator.SetBool("IsOpen", isOpen);
    }
}


 