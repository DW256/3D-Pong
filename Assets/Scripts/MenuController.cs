using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Gameplay Scene");
    }

    public void howToPlay()
    {
        SceneManager.LoadScene("How to Play Scene");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
