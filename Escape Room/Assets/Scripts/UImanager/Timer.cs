using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private bool _stop;
    public float timeValue = 1800;
    public TextMeshProUGUI timeText;
    private void Update()
    {
        if (!_stop) { 
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }else
        {
            timeValue = 0;
        }
        }
        DisplayTime(timeValue);
    }
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 10)
        {
            timeText.color = Color.red;
        }
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }else if (timeToDisplay > 0)
        {
            timeToDisplay += 1;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void Stop()
    {
        _stop = true;
    }
}
