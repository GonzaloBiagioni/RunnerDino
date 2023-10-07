using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MuertePersonaje : MonoBehaviour
{
    public Text puntajeFinalText;
    public Score highScore;

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ActiveScreen()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        puntajeFinalText.text = (highScore.contadorScore * 10).ToString("0");
    }
    
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
