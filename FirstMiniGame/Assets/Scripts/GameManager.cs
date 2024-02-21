using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float delayRestart = 1f;
    public GameObject LevelCompleteUI;
    public GameObject GameOverUI;
    public GameObject[] playerIU;
    private bool levelPassed = false;

    public void GameOver()
    {
        if (!levelPassed)
        {
            Debug.Log("GAME OVER");
            OffPlayerUI();
            Invoke("Retry", 1f);
            Invoke("ReloadLevel", 3f);
        }
    }

    public void LevelComplete()
    {
        levelPassed = true;
        Debug.Log("Level Completed!");
        OffPlayerUI();
        LevelCompleteUI.SetActive(true);


    }

    private void OffPlayerUI()
    {
        foreach (var ui in playerIU)
        {
            ui.SetActive(false);
        }
    }
   
    void Retry()
    {
        GameOverUI.SetActive(true);
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
