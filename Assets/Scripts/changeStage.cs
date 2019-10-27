using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeStage : MonoBehaviour
{

    public void changeToFrac0() { // Fraction 1
        SceneManager.LoadScene(0);
    }

    public void changeToFrac1() { // Fraction 1
        SceneManager.LoadScene(1);
    }
    public void changeToFrac2() { // Fraction 2
        SceneManager.LoadScene(3); 
    }
    public void changeToFrac3() { // Fraction 3
        SceneManager.LoadScene(5);
    }
    public void changeToFrac4()
    { // Fraction 3
        SceneManager.LoadScene(8);
    }

}
