using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    private float currentTime = 0f;
    private float startingTime = 0f;

    private bool isRunning = true;

    [SerializeField] Text countdownText;

    public void Start()
    {
        currentTime = startingTime;
        countdownText.text = "Time" + currentTime.ToString("0.00");
        countdownText.color = Color.white;
    }


    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            currentTime += 1 * Time.deltaTime;
            countdownText.text = "Time" + currentTime.ToString("0.00");
        }

        if (currentTime > 100)
        {
            Stop();
        }


    }
    public void Stop()
    {
        isRunning = false;

        countdownText.text = "Game end";

    }

}
