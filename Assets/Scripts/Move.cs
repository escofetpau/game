using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Move : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    Vector2 targetPosition;

    public float speed;
    public bool endTime = false;

    public GameObject restartPanel;
    public GameObject restartCountdown;

    // Start is called before the first frame update
    void Start() 
    {
        targetPosition = GetRandomPosition();
        
    }

    bool valid() {
        if (transform.position.y > maxY || transform.position.y < minY)
            return false;
            
        if (transform.position.x > maxX || transform.position.x < minX)
            return false;
        return true;
    }

    // Update is called once per frame
    void Update()
    { 
        endTime = restartCountdown.GetComponent<CountdownTimer>().isEnd();

        if ((Vector2)transform.position != targetPosition && valid()) {
             transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        } else {
            targetPosition = GetRandomPosition();
        }
    }

    Vector2 GetRandomPosition() {
        float RandomX = Random.Range(minX, maxX);
        float RandomY = Random.Range(minY, maxY);
        return new Vector2(RandomX, RandomY);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "AbnormalCell" && !endTime) {
            restartPanel.SetActive(true);
            restartCountdown.SetActive(false);
        }
    }


}
