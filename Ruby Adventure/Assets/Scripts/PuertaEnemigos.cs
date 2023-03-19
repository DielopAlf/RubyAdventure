using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaEnemigos : MonoBehaviour
{
    public Enemigo zonaEnemigos;
    public Animator animator;
    public Collider2D colliderPuerta;
    public int cantidadEnemigosParaAbrir = 10;

    private bool puertaAbierta = false;

    private void Update()
    {
        if (zonaEnemigos.numEnemigosEliminados >= cantidadEnemigosParaAbrir && !puertaAbierta)
        {
            AbrirPuerta(); // Iniciamos la animaci�n si se han eliminado la cantidad de enemigos requeridos y la puerta a�n no ha sido abierta
        }
    }

    private void AbrirPuerta()
    {
        animator.SetTrigger("AbrirPuerta"); // Activamos el trigger del animator que inicia la animaci�n de la puerta
        puertaAbierta = true; // Marca la puerta como abierta
        colliderPuerta.enabled = false; // Desactivamos el collider de la puerta para que no se pueda abrir nuevamente
    }

}
/*{
    public Enemigo zonaEnemigos;
public Animator animator;
public Collider2D colliderPuerta;

private bool puertaAbierta = false;

private void Update()
{
    if (zonaEnemigos.numEnemigosRestantes == 0 && !puertaAbierta)
    {
        AbrirPuerta(); // Iniciamos la animaci�n si no quedan enemigos en la zona y la puerta a�n no ha sido abierta
    }
}

private void AbrirPuerta()
{
    animator.SetTrigger("AbrirPuerta"); // Activamos el trigger del animator que inicia la animaci�n de la puerta
    puertaAbierta = true; // Marca la puerta como abierta
    colliderPuerta.enabled = false; // Desactivamos el collider de la puerta para que no se pueda abrir nuevamente
}*/


/*public Enemigo zonaEnemigos;
public Animator animator;

private void Update()
{
    if (zonaEnemigos.numEnemigosRestantes == 0)
    {
        AbrirPuerta(); // Iniciamos la animaci�n si no quedan enemigos en la zona
    }
}

private void AbrirPuerta()
{
    animator.SetTrigger("AbrirPuerta"); // Activamos el trigger del animator que inicia la animaci�n de la puerta
}*/




