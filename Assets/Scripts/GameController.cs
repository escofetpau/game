﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void Refresh() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
