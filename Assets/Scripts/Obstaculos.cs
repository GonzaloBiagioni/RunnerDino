using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public float velocidad = 3f;
    public float tiempoVivo = 0f;
    public float tiempodevidamaximo = 5f;


    void Update()
    {
        transform.position -= new Vector3(velocidad * (Time.deltaTime), 0, 0);
        tiempoVivo += Time.deltaTime;

        if (tiempoVivo >= tiempodevidamaximo)
        {
            Destroy(this.gameObject);
        }
    }
}
