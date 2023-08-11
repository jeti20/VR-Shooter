using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private bool countdownStarted = false;

    private int timeLeft;


    private void Update()
    {
        if (!countdownStarted)
        {
            StartCountdown();
        }
    }

    private void StartCountdown()
    {
        countdownStarted = true;
        StartCoroutine(Countdown(timeLeft = GameManager.instance.timeLeft, 1, "end"));
    }


    IEnumerator Countdown(int time, int steptime, string endmessage)
    {

        for (int i = time; i >= 0; i--)
        {
            yield return new WaitForSeconds(steptime);
            Debug.Log(i.ToString());
            //not sure why but without this condiition the counter in UI go -1 insted of stopping on 0. Propably precouse conditions in for loop.
            if (i >=1)
            GameManager.instance.timeLeft--;
        }
        GameManager.instance.timeOver = true;
        Debug.Log(endmessage);
    }
}
