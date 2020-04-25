﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    float currentTime;
    public float startingTime;
    
    

    public Text clockTime;
    
    void Start()
    {
        currentTime = startingTime;
    }

    
    void Update()
    {
        currentTime -= 1*Time.deltaTime;
        int seconds = (int)(currentTime % 60);
        int minutes = (int)(currentTime / 60);

        if (currentTime > 0)
        {
            clockTime.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
        if (currentTime <= 0)
        {
            clockTime.text = "00:00";
        }
        
    }
}