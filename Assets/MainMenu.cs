using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("Options");
    }

    public void MainMenu1()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CreditsButton1()
    {
        SceneManager.LoadScene("Credits");
    }



    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
