﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void SinglePlayer()
    {
        SceneManager.LoadScene(1);
    }

    public void Multiplayer()
    {
        SceneManager.LoadScene(2);
    }
    
    public void Quit()
    {
        Application.Quit();
    }


}
