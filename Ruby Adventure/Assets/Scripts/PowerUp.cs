using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float duration = 5.0f;
    public float newFireRate = 0.5f;
    public AudioClip powerUpSound;

    private RubyController ruby;

    private void Start()
    {
        ruby = GameObject.FindGameObjectWithTag("Player").GetComponent<RubyController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //ruby.ActivateFastFire(duration, newFireRate);
            //ruby.AddRubyPoints(10);
            AudioSource.PlayClipAtPoint(powerUpSound, transform.position);
            Destroy(gameObject);
        }
    }
}