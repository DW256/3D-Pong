using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOverController : MonoBehaviour
{
    public GameObject menu;
    public TextMeshProUGUI winner;
    public StatsManager manager;

    private void resume()
    {
        Time.timeScale = 1;
    }

    private void pause()
    {
        Time.timeScale = 0;
    }

    public void openMenu() 
    {
        pause();
        menu.SetActive(true);
        winner.text = manager.getWinner()+ " WIN";
    }

    public void backToMainMenu()
    {
        resume();
        SceneManager.LoadScene("MainMenu");
    }

    public void replay()
    {
        resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
