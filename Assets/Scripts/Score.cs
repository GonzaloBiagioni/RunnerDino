using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float contadorScore = 0f;
    void Update()
    {
        contadorScore += Time.deltaTime;
        scoreText.text = (contadorScore * 10).ToString("0");
    }
}
