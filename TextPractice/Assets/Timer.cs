using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    Text text;
    float time;
    Stopwatch stopwatch;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        time = 10.0f;
        stopwatch = new Stopwatch();
        stopwatch.Start();
    }

    // Update is called once per frame
    void Update()
    {
        time = (10000.0f - stopwatch.ElapsedMilliseconds) / 1000.0f;
        if (time <= 0.0f)
        {
            time = 0.0f;
            stopwatch.Stop();
        }
        text.text = "Timer: " + time;
    }

}
