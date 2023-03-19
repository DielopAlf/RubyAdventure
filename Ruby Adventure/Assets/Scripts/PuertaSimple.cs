using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaSimple : MonoBehaviour
{
    public Animation doorAnimation;

    void Start()
    {
        doorAnimation = GetComponent<Animation>();
    }

    public void OnButtonDown()
    {
        doorAnimation.Play();
    }

    public void OnButtonUp()
    {
        doorAnimation.Stop();
    }
}

/*{
    public Animator doorAnimator;

public void OnPointerDown()
{
    // Reproducir la animaci�n de apertura de la puerta
    doorAnimator.Play("OpenDoor");
}

public void OnPointerUp()
{
    // Reproducir la animaci�n de cierre de la puerta
    doorAnimator.Play("CloseDoor");
}
}

 
 
 
 */