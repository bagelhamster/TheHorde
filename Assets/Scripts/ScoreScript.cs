using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreValue = 0;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreValue = 0;
    }
    void Update()
    {
        scoreText.text = "Score: " + scoreValue;
    }
}
