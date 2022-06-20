using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[] score = {0,0,0,0};
    public int[] kebobolan = {0,0,0,0};
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(Paddle lastPaddle) 
    {
        score[(int)lastPaddle] += 1;

    }

    public void addKebobolan(Paddle paddle)
    {
        kebobolan[(int)paddle] += 1;

    }

    public void popPaddle(Paddle paddle)
    {
        
    }
}
