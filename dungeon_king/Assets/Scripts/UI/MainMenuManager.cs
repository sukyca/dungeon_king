using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }
     private void Awake()
    {

    }


    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void HighScore()
    {
        Debug.Log("Not implemented yet");
    }

    public void Quit()
    {
        Debug.Log("Quitting the game");
        Application.Quit();
    }
}



