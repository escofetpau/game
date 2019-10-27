using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    private int CountdownTime = 15;
    public Text countdownDisplay;
    public GameObject restartPanel;
    public bool timeractive = true;

    private void Start() {

        StartCoroutine(CountdownToEnd());
    }

    IEnumerator CountdownToEnd() {

        while(CountdownTime > 0 && timeractive == true) {

            countdownDisplay.text = "Time left: " + CountdownTime.ToString();

            yield return new WaitForSeconds(1);

            CountdownTime--;
        }

        countdownDisplay.text = "END";

        restartPanel.SetActive(true);
        //canvi vista
    }

    public bool isEnd () {
        return CountdownTime <= 0;
    }

}

