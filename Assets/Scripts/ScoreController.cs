using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI[] score;

    public StatsManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (int Paddle in Paddle.GetValues(typeof(Paddle)))
        {
            //Debug.Log(Paddle);
            score[Paddle].text = "Player " + (Paddle+1) + "\n" + manager.kebobolan[Paddle].ToString();
        }
    }
}
