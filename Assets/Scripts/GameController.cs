using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject pauseUI;
    private bool isPaused = false;

    void Start()
    {

        gameOverUI.SetActive(false);
        pauseUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    public void GameOver() 
    {
        gameOverUI.SetActive(true);
    }

    private void TogglePauseMenu()
    {
        if (!isPaused)
        {   
            pauseUI.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
            
        }
        else
        {
            pauseUI.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
        }
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");  
    }
    
    public void continueGame()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false; 
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void quit()
    {
        Application.Quit();  
    }

}
