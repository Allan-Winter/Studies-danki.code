using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public Text healthText;
    public Text scoreText;

    public int score;

    public static GameController instance;

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int value)
    {
        score += value;
        scoreText.text = "X " + score.ToString();
    }

    public void UpdateLives(int value)
    {
        healthText.text ="X " + value.ToString();

    }
}
