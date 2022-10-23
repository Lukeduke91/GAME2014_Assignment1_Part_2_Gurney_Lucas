using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// BackgroundBehaviour.cs
/// Lucas Gurney 
/// 101313633
/// October 2 2022 12:05 PM
/// This program Loads the scenes for the button inputs 
/// https://medium.com/geekculture/changing-scenes-in-unity-ce4acf3a3513

public class LoadScenes : MonoBehaviour
{
    public void LoadMainGame()
    {
        //this Loads to the Main Game scene
        SceneManager.LoadScene(1);
    }

    public void LoadInstructions()
    {
        //This loads to the instruction scene
        SceneManager.LoadScene(2);
    }

    public void LoadMainMenu()
    {
        // this Loads to the Main Menu
        SceneManager.LoadScene(0);
    }

    public void LoadGameOver()
    {
        // this loads to the Game over scene
        SceneManager.LoadScene(3);
    }
}
