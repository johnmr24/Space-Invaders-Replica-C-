using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{

    public GameControl gameController;
    int score;
    private int currentScene;

    public void LoadNextScene()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

}
