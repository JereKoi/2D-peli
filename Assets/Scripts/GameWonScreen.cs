﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameWonScreen : MonoBehaviour
{
    public Text demonsslain;
    public void Setup(int slainscore)
    {
        gameObject.SetActive(true);
        demonsslain.text = slainscore.ToString() + " Slain Demons: ";
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
