using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    // Start is called before the first frame update
    //public GameObject scoreText;
    private int scoreValue;
    private bool isCompleted;
    void Start()
    {   
        isCompleted = false;
        scoreValue = 0;
    }


    public void addScore () {
        ++scoreValue;
        GetComponent<Text>().text = "Score: " + scoreValue;
        if (scoreValue >= 15) isCompleted = true;
    }

    public bool isCompletedConsult() {
        return isCompleted;
    }
}
