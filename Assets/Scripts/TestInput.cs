using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class TestInput : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaDeSalto = 20f;
    Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        



    }

    private void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical);
        movimiento.Normalize();

        GetComponent<Rigidbody2D>().velocity = movimiento * velocidad;

        if (Input.GetButton("Fire1"))
        {
            rb2D.AddForce(Vector2.up * fuerzaDeSalto, ForceMode2D.Impulse);
            Debug.Log("Space");
        }
    }
}
