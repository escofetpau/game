using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GS : MonoBehaviour
{
    public void GoToGameScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit() {
        SceneManager.LoadScene(0);
    }

    public void Next() {
        SceneManager.LoadScene(2);
    }
}

