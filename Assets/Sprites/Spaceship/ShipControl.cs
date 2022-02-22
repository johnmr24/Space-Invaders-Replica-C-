using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public float playerSpeed = 10f;
    public GameControl gameController;
    public GameObject bulletPrefab;
    public float reloadTime = 0.5f;
    private float elapsedTime = 0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        //player movement
        float xMovement = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        //float xPosition = Mathf.Clamp(xMovement, -7f, 7f);

        if (transform.position.x < 7 && transform.position.x > -7)
        {
            transform.Translate(xMovement, 0f, 0f);
        }
        else
        {
            if (xMovement < 0 && transform.position.x >= 7)
            {
                transform.Translate(xMovement, 0f, 0f);
            }
            else if (xMovement > 0 && transform.position.x <= -7)
            {
                transform.Translate(xMovement, 0f, 0f);
            }
        }

        if (Input.GetButtonDown("Jump") && elapsedTime > reloadTime)
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

            elapsedTime = 0f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        gameController.subtractLife();
        Destroy(other.gameObject);
    }
}
