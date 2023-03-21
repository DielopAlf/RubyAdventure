using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nivelsuperado : MonoBehaviour
{
    public int enemigosarreglados;
    public int enemigos;
    public static nivelsuperado instance;
    public PUERTA2[] puertasfinales;
    bool final;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        final = false;
    }

    void Update()
    {
        comprobarfinal();
    }

    void comprobarfinal()
    {
        if (enemigosarreglados >= enemigos && final == false)
        {
            foreach (PUERTA2 puerta in puertasfinales)
            {
                puerta.abrir();
            }

            final = true;
        }
    }
}
