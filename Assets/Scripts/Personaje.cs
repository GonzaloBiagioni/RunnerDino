using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
    private Rigidbody2D personajeRB;
    public float fuerzasalto = 5f;
    public bool tocarpiso = true;
    public GameObject Pausa;

    [SerializeField] MuertePersonaje deathmenu;

    void Start()
    {
        Pausa.SetActive(false);
        personajeRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && tocarpiso)
        {
            personajeRB.AddForce(Vector2.up * fuerzasalto, ForceMode2D.Impulse);
            tocarpiso = false;
        }       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Pausa.SetActive(true);
            Time.timeScale = 0f;
        }
        tocarpiso = true;
    }
}
