using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invencibilidad : MonoBehaviour
{
    public float duration = 5.0f; // duración del power up
    public float rotationSpeed = 100.0f; // velocidad de rotación del objeto

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            RubyController rubyController = other.GetComponent<RubyController>();
            if (rubyController != null)
            {
                rubyController.ActivateInvincibility(duration);
                Destroy(gameObject);
            }
        }
    }

    // El objeto rota continuamente
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}