﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject TextObj;
    int scoreValue;
    private void Start() {
        
    }

    void OnCollisionEnter2D (Collision2D col) {
        Destroy(gameObject);
        TextObj.GetComponent<ScoreScript>().addScore();
    }
}
