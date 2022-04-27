using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Platform Object")]
    public GameObject Platform;
    float pos = 0;

    [Header("Game Over UI Canvas")]
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            SpawnPlatforms();
        }
    }

    void SpawnPlatforms()
    {
        Instantiate(Platform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);
        pos += 2.5f;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
