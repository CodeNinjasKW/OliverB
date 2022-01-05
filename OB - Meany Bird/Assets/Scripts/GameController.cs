using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Game over UI for displaying if the game is over")]
    public GameObject GameOverCanvas;

    [Header("Score UI for displaying score")]
    public GameObject ScoreCanvas;

    [Header("Spawner object for spawning objects in game")]
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        ScoreCanvas.SetActive(true);
        GameOverCanvas.SetActive(false);
        spawner.SetActive(true);
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        spawner.SetActive(false);
        Time.timeScale = 0;
    }
}
