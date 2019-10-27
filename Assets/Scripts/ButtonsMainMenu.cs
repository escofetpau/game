using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsMainMenu : MonoBehaviour
{
    public Animator animator;
    public GameObject mainMenu;
    public GameObject stagesMenu;

    public void StartGame() {
        animator.SetTrigger("WhiteFadeOut");
    }

    public void QuitGame() {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void stages() {
        stagesMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void goMainMenu() {
        stagesMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
