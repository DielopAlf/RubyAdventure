using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public Sprite[] doorSprites;
    public float animationDuration;
    public float timeBetweenFrames;

    private bool isButtonDown = false;
    private float animationTimer = 0.0f;
    private int currentSprite = 0;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = doorSprites[0];
    }
}
    /*public void OnPointerDown(PointerEventData eventData)
    {
        isButtonDown = true;
        animationTimer = 0.0f;
        currentSprite = 0;
        spriteRenderer.sprite = doorSprites[currentSprite];
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isButtonDown = false;
        spriteRenderer.sprite = doorSprites[doorSprites.Length - 1];
    }

    void Update()
    {
        if (isButtonDown)
        {
            animationTimer += Time.deltaTime;
            if (animationTimer >= timeBetweenFrames)
            {
                animationTimer = 0.0f;
                currentSprite++;
                if (currentSprite >= doorSprites.Length - 1)
                {
                    currentSprite = doorSprites.Length - 1;
                }
                spriteRenderer.sprite = doorSprites[currentSprite];
            }
        }
    }
    {
   

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Door : MonoBehaviour
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
     
     
     
    

} */