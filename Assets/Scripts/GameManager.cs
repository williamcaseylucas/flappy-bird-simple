using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public Player player;
    private int score;

    private void Awake()
    {
        Application.targetFrameRate= 60;  
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();
        
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject); // To remove the whole object  
        }
        Debug.Log("This is happening");
    }

    public void Pause()
    {
        Time.timeScale = 0; // Pauses everything because everything is multiplied by delta time
        player.enabled= false; 
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
        // Debug.Log("Game Over");
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }


}
