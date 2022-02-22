using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDestroy : MonoBehaviour
{
    public GameControl gameController;

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
