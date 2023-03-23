using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;
    public float changeTime = 3.0f;

    public ParticleSystem smokeEffect;

    public AudioClip robotFixed;

    Rigidbody2D rigidbody2d;
    float timer;
    int direction = 1;
    bool broken = true;
    float fixTime = 0.0f; // variable para hacer seguimiento del tiempo de arreglado

    Animator animator;

    AudioSource audioSource; 

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
       // nivelsuperado.instance.enemigos+=1;
    }

    // Update is called once per frame
    void Update()
    {
        if (broken)
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                direction = -direction;
                timer = changeTime;
            }

            Vector2 position = rigidbody2d.position;

            if (vertical)
            {
                position.y = position.y + Time.deltaTime * speed * direction;
                animator.SetFloat("Move X", 0);
                animator.SetFloat("Move Y", direction);
            }
            else
            {
                position.x = position.x + Time.deltaTime * speed * direction;
                animator.SetFloat("Move X", direction);
                animator.SetFloat("Move Y", 0);
            }

            rigidbody2d.MovePosition(position);
        }
      /*  else // si el enemigo está arreglado, esperar hasta que expire el tiempo de reparación
        {
            fixTime -= Time.deltaTime;

            if (fixTime < 0)
            {
                broken = true;
                rigidbody2d.simulated = true;
                animator = GetComponent<Animator>();
                animator.SetTrigger("Broken");
                smokeEffect.Play();
            }
        }*/
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController>();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }

    public void Fix()
    {
        if (broken) // sólo se puede arreglar si está roto
        {
            broken = false;
            rigidbody2d.simulated = false;
            animator.SetTrigger("Fixed");
            animator = GetComponent<Animator>();
            smokeEffect.Stop();
            audioSource.loop= false;
            audioSource.PlayOneShot(robotFixed);
            nivelsuperado.instance.enemigosarreglados+=1;

            // establecer el tiempo de reparación a 5 segundos
           // fixTime = 5.0f;
        }
    }
}