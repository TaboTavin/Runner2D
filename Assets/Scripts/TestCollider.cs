using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colision Detectada");

        // Aqui es donde puedes agregar cualquier accion que quieras realizar cuandop ocurra una colision.
    }
}
