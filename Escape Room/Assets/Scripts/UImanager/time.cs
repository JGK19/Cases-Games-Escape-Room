using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{

    public Text timeText;
    public float timecount;
    public int num = 60;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
       CountTime();

    }

    void CountTime() {
        timecount += Time.deltaTime;
        if (timecount >= 60) {
            num -= 1;
            timecount = 0;
            refresh();
        }
    }

    void refresh() {
        timeText.text = num.ToString();
    }

    void Pause() {
        

    }
}
