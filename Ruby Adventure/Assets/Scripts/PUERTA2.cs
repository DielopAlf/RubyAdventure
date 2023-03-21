using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUERTA2 : MonoBehaviour
{
    public Animator animator;
    public GameObject spritepuerta;
    SpriteRenderer sprite;
    BoxCollider2D COLLIDER;
    bool playerzone;
    bool open;

    void Start()
    {
        playerzone = false;
        open = false;
        sprite = spritepuerta.GetComponent<SpriteRenderer>();
        COLLIDER = spritepuerta.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (playerzone == true && open == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                abrir();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerzone = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerzone = false;
            if (open == true)
            {
                cerrar();
            }
        }
    }

    public void abrir()
    {
        open = true;
        animator.SetBool("isOpen", true);
        sprite.enabled = false;
        COLLIDER.enabled = false;
    }

    public void cerrar()
    {
        open = false;
        animator.SetBool("isOpen", false);
        sprite.enabled = true;
        COLLIDER.enabled = true;
    }

    public void resetPuerta()
    {
        open = false;
        animator.SetBool("isOpen", false);
        sprite.enabled = true;
        COLLIDER.enabled = true;
    }
}
