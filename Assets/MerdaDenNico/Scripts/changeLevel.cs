using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeLevel : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isCompleted;

    public GameObject Score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isCompleted = Score.GetComponent<ScoreScript>().isCompletedConsult();
    }

    private void OnCollisionEnter2D(Collision2D collision) {

            
        if (isCompleted == true) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
