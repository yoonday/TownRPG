using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timeDisplay;

    void Update()
    {
        
        timeDisplay.text = DateTime.Now.ToString("HH:mm");
    }
}