using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    // Start is called before the first frame update
    //public GameObject scoreText;
    private int scoreValue;
    void Start()
    {
        scoreValue = 0;
    }


    public void addScore () {
        ++scoreValue;
        GetComponent<Text>().text = "Score: " + scoreValue;
    }
}
