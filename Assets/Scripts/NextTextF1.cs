using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextTextF1 : MonoBehaviour
{

    public GameObject text1;

    public GameObject nextB;
    public GameObject backB;
    public GameObject startGameB;

    public GameObject tumorImage;

    public static int textIndex;

    public Animator animatorText2;

    Text instruction;

    // Hey Buddy! 134
    string [] textos = new string[] {
        "Let's learn together about cancer while having fun!",
        "How does cancer start?",
        "Cancer starts with a tumor.\n\nA tumor can be benign or malignant.\n\n\n\n\n\n\n\n",
        "In the process of diagnosis we have to distinguish between  normal cells and abnormal cells.",
        "Don't let the cells touch the cancer cells!\n\nHave in mind that:\n\n- Cancer cells don’t stop reproducing\n\n- Don’t obey signals from other calls\n\n- Don’t stick together\n\n"
    };
    
    void Start () {
        instruction = text1.GetComponent<Text>();
        textIndex = -1;
        nextB.SetActive(true);
        backB.SetActive(true);
        startGameB.SetActive(false);
        //stumorImage.SetActive(false);
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
            case 0:
                instruction.fontSize = 72;
            break; 

            case 1:
                tumorImage.SetActive(false);
                instruction.fontSize = 83;
            break; 

            case 2:
                instruction.fontSize = 50;
                Debug.Log("trues");
                tumorImage.SetActive(true);
            break; 
            
            case 3:
                Debug.Log("false");
                tumorImage.SetActive(false);
                instruction.fontSize = 59;
            break; 

            case 4:
                instruction.fontSize = 50;
                nextB.SetActive(false);
                backB.SetActive(false);
                startGameB.SetActive(true);
            break; 
        }

        instruction.text = textos[textIndex];
    }

}
