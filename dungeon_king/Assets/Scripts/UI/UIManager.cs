using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private AudioClip gameOverSound;
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject winScreen;

    private void Awake()
    {
        gameOverScreen.SetActive(false);
        pauseScreen.SetActive(false);

        try
        {
            winScreen.SetActive(false);
        }
        catch
        {
            
        }
    
    
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Resume()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        SoundManager.instance.PlaySound(gameOverSound);

    }

    public void Win()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale> 0f)
                Pause();
            else
                Resume();
        }

    }


    public bool IsPaused()
    {
        return pauseScreen.activeSelf;
    }


}
