using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public Text healthText;
    public Text scoreText;

    public int score;
    public int totalScore;

    public GameObject pauseObj;
    public GameObject gameOverObj;

    public static GameController instance;

    private bool ispaused;

    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        totalScore = PlayerPrefs.GetInt("score");
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }

    public void UpdateScore(int value)
    {
        score += value;
        scoreText.text = "X " + score.ToString();

        PlayerPrefs.SetInt("score", score + totalScore);
    }

    public void UpdateLives(int value)
    {
        healthText.text ="X " + value.ToString();

    }

    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Game is paused
            ispaused = !ispaused;
            pauseObj.SetActive(ispaused);
        }

        if (ispaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void GameOver()
    {
        gameOverObj.SetActive(true);
        //Time.timeScale = 0f;
    }

    public void RstartGame()
    {
        SceneManager.LoadScene(1);
    }
}
