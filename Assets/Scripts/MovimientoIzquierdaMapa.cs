using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoIzquierdaMapa : MonoBehaviour
{
    public float velocidadMovimiento = 2.0f;
    private Vector3 posicionInicial;
    public float offset;

    private void Start()
    {
        posicionInicial = transform.position;
    }

    private void Update()
    {
        transform.Translate(Vector3.left * velocidadMovimiento * Time.deltaTime);

        if (transform.position.x <= posicionInicial.x - offset)
        {
            transform.position = posicionInicial;
        }
    }
}
