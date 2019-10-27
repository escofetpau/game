using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextTextF3 : MonoBehaviour
{

    public GameObject text1;

    public GameObject nextB;
    public GameObject backB;
    public GameObject startGameB;

    public GameObject atomImage;

    //public GameObject tumorImage;

    public static int textIndex;

    public Animator animatorText2;

    Text instruction;

    // Hey Buddy! 134
    string [] textos = new string[] {
        "Let's turn the machine on and make it work!\n\n\n"
    };
    
    void Start () {
        instruction = text1.GetComponent<Text>();
        textIndex = -1;
        nextB.SetActive(true);
        backB.SetActive(true);
        startGameB.SetActive(false);
       // tumorImage.SetActive(false);
    }

    public void changeToNextText () {
        ++textIndex;
        if (textIndex < textos.Length) {
            animatorText2.SetTrigger("Text2");
        }
        else {
            animatorText2.SetTrigger("WhiteFadeOut"); // Joc Alba
        }    
    }

    public void changeToPreviousText () {
        if (textIndex == -1)
        {
            SceneManager.LoadScene(0);
        }
        if (textIndex > 0) {
            --textIndex;
            animatorText2.SetTrigger("Text2");
        }
    }

    public void changeText () {

        switch (textIndex) {
            case 0:
                instruction.fontSize = 60;
                atomImage.SetActive(true);
                nextB.SetActive(false);
                backB.SetActive(false);
                startGameB.SetActive(true);
            break; 
        }

        instruction.text = textos[textIndex];
    }

}
