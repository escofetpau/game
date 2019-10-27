using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveAbnormal : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    Vector2 targetPosition;

    public float speed;

    // Start is called before the first frame update
    void Start() 
    {
        targetPosition = GetRandomPosition();
    }

    // Update is called once per frame
    void Update()
    { 
        if ((Vector2)transform.position != targetPosition) {
             transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        } else {
            targetPosition = GetRandomPosition();
            Debug.Log(targetPosition);
        }
    }

    Vector2 GetRandomPosition() {
        float RandomX = Random.Range(minX, maxX);
        float RandomY = Random.Range(minY, maxY);
        return new Vector2(RandomX, RandomY);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Nada") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


}
