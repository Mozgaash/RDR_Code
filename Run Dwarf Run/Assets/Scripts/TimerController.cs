using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{

    public Text timerText;
    private float seconds = 0.0f;
    private int minutes = 0;
    private int hours = 0;

    private bool changeToMin = false;
    private bool changeToHours = false;

    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempo();
    }
    private void tiempo()
    {
        seconds = seconds + Time.deltaTime;

        if(seconds >= 60)
        {
            minutes++;
            seconds -= 60;
            changeToMin = true;
            Debug.Log("sumo 1 minuto");
        }

        if (minutes >= 60)
        {
            hours++;
            minutes -= 60;
            changeToHours = true;
            Debug.Log("sumo 1 hora");
        }

        if (seconds < 60 && !changeToMin)
        {
            timerText.text = "" + seconds.ToString("f2");
            Debug.Log("segundos: " + seconds + "/////" + timerText.text);
        }
        else if (changeToMin)
        {
            timerText.text = "" + minutes + ":" + seconds.ToString("f2");
        } else if (changeToHours)
        {
            timerText.text = "" + hours + ":" + minutes + ":" + seconds.ToString("f2");
        }
    }
}
