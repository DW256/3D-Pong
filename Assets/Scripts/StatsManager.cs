using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    //public int[] score = { 0, 0, 0, 0 };
    public int[] kebobolan = { 0, 0, 0, 0 };
    private GameObject[] paddles;
    private string winner;

    public GameOverController GameOver;

    // Start is called before the first frame update
    void Start()
    {
        winner = "Player ";
    }

    //public void addScore(Paddle lastPaddle)
    //{
    //    score[(int)lastPaddle] += 1;

    //}

    public void addKebobolan(Paddle paddle)
    {
        kebobolan[(int)paddle] += 1;

    }

    public void checkPlayers()
    {
        paddles = GameObject.FindGameObjectsWithTag("Player");
        if (paddles.Length == 1)
        {
            winner = "Player " + ((int)paddles[0].GetComponent<PaddleController>().paddleName + 1);
            GameOver.openMenu();
        }
    }

    public string getWinner()
    {
        return winner;
    }
}
