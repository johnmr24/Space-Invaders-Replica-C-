using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    private GameControl gameController;

    void Start()
    {
        gameController = GameObject.FindObjectOfType<GameControl>();
    }

    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        gameController.addScore();
        Destroy(gameObject);
    }
}
