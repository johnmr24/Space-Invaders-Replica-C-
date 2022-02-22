using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public SceneSwitcher sceneSwitcher;
    public Text scoreText, gameOverText;
    public Slider healthBar;
    int playerScore = 0;

    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void subtractLife()
    {
        healthBar.value -= 0.2f;
    }

    public void playerDied()
    {
        sceneSwitcher.LoadNextScene();
    }

    void Update()
    {
        
        if (healthBar.value <= 0.2f)
        {
             playerDied();
        }
        
    }
}
