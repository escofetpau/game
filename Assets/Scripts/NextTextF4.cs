using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextTextF4 : MonoBehaviour
{

    public GameObject text1;

    public GameObject nextB;
    public GameObject backB;
    public GameObject startGameB;

    //public GameObject tumorImage;

    public static int textIndex;

    public Animator animatorText2;

    Text instruction;

    // Hey Buddy! 134
    string [] textos = new string[] {
        "Remember how far you've come, but alse that you canalways keep learning!",
        "If you want to learn even more check the Augmented",
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
        if (textIndex > 0) {
            --textIndex;
            animatorText2.SetTrigger("Text2");
        }
    }

    public void changeText () {

        switch (textIndex) {
            case 1:
              //  instruction.fontSize = 50;
                nextB.SetActive(false);
                backB.SetActive(false);
                startGameB.SetActive(true);
            break; 
        }

        instruction.text = textos[textIndex];
    }

}
