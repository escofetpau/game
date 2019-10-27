using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextTextF2 : MonoBehaviour
{
 
    public GameObject text1;

    public GameObject nextB;
    public GameObject backB;
    public GameObject startGameB;

    public static int textIndex;

    public GameObject rayImage;

    public Animator animatorText2;

    Text instruction;

    // Hey Buddy! 134
    string [] textos = new string[] {
        "The most common cancer therapies are Surgery, chemotherapy and radiotherapy",
        "Radiotherapy helps you beat the malignant cells without you seen or feeling anything.",
        "Do you know how it works? It look's like magic!",
        "First to make the machine work we need to get energy.",
        "Help us get enough energy for the machine!  \n\n\n\n"
    };

    
    void Start () {
        instruction = text1.GetComponent<Text>();
        textIndex = -1;
        nextB.SetActive(true);
        backB.SetActive(true);
        startGameB.SetActive(false);
    }

    public void changeToNextText () {
        ++textIndex;
        if (textIndex < textos.Length) {
           // instruction.text = textos[textIndex];
            animatorText2.SetTrigger("Text2");
        }
        else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        /*else {
            animatorText2.SetTrigger("WhiteFadeOut"); // Joc Alba
        } */   
    }

    public void changeToPreviousText () {
        if (textIndex == -1)
        {
            SceneManager.LoadScene(0);
        }
        if (textIndex > 0) {
            --textIndex;
            //instruction.text = textos[textIndex];
            animatorText2.SetTrigger("Text2");
        }
    }

    public void changeText () {
        switch (textIndex) {
            case 0:
               // instruction.fontSize = 72;
            break; 

            case 1:
                //instruction.fontSize = 83;
            break; 

            case 2:
               // instruction.fontSize = 50;
               // tumorImage.SetActive(true);
            break; 
            
            case 3:
                rayImage.SetActive(false);
               // tumorImage.SetActive(false);
               // instruction.fontSize = 59;
            break; 

            case 4:
              //  instruction.fontSize = 50;
                rayImage.SetActive(true);
                nextB.SetActive(false);
                backB.SetActive(false);
                startGameB.SetActive(true);
            break; 
        }
        instruction.text = textos[textIndex];
              
    }
}
