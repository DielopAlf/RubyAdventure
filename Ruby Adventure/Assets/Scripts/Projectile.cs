using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int maxAmmo = 10; // La cantidad máxima de proyectiles que el jugador puede lanzar
    private int currentAmmo; // La cantidad actual de proyectiles que el jugador tiene

    Rigidbody2D rigidbody2d;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentAmmo = maxAmmo; // Inicializa la cantidad actual de proyectiles con la cantidad máxima
    }

    public void Launch(Vector2 direction, float force)
    {
        if (currentAmmo > 0) // Verifica si el jugador tiene suficientes proyectiles para lanzar
        {
            rigidbody2d.AddForce(direction * force);
            currentAmmo--; // Decrementa la cantidad actual de proyectiles
            Debug.Log("Ammo remaining: " + currentAmmo); // Imprime la cantidad actual de proyectiles
        }
        else
        {
            Debug.Log("Out of ammo!"); // Imprime que el jugador se quedó sin proyectiles
        }
    }

    void Update()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController e = other.collider.GetComponent<EnemyController>();
        if (e != null)
        {
            e.Fix();
        }

        Destroy(gameObject);
    }
}