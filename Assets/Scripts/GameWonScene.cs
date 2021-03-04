using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameWonScene : MonoBehaviour
{
    public Text demonsslain;
    public void Setup(int slainscore)
    {
        gameObject.SetActive(true);
        demonsslain.text = slainscore.ToString() + " ";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
