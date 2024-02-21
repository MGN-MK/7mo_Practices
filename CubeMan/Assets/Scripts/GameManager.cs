using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float delayRestart = 1f;
    public GameObject LevelCompleteUI; 
    private bool gameHasEnded = false;

    public void GameOver()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");

            Invoke("Restart", delayRestart);
        }
    }

    public void LevelComplete()
    {
        Debug.Log("Level Completed!");
        LevelCompleteUI.SetActive(true);

        Invoke("Restart", delayRestart);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
