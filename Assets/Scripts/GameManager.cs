using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score;
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject playButton, deathScreen;
    
    void Start()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        Time.timeScale = 1;
        playButton.SetActive(false);
        GameObject.Find("Floor").GetComponent<Animator>().enabled = true;
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score + "";
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        deathScreen.SetActive(true);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        deathScreen.SetActive(false);
    }
}
