using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class AmmoPickup : MonoBehaviour
{
   
    public int ammoAmount = 10; // La cantidad de munición que da el objeto

    void OnTriggerEnter2D(Collider2D other)
    {
        // Si el objeto que colisiona tiene el tag "Player", aumenta la munición del jugador y destruye este objeto
        if (other.CompareTag("Player"))
        {
            RubyController ruby = other.GetComponent<RubyController>();
            if (ruby != null)
            {
                ruby.ammoCount += ammoAmount;
                ruby.ammoCount = Mathf.Clamp(ruby.ammoCount, 0, ruby.maxAmmo);
                ruby.uiAmmo.SetAmmo(ruby.ammoCount);
                Destroy(gameObject);
            }
        }
    }
}