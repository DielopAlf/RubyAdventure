using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        Debug.Log("me pincho");
        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }

}
