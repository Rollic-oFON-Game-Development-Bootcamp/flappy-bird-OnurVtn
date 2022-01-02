using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdRigidbody;
    [SerializeField] private float jumpSpeed;
    private GameManager gameManager;
    
    void Start()
    {
        gameManager = GameObject.Find("Scripts").GetComponent<GameManager>();
    }

    void Update()
    {
        BirdMovement();
    }

    private void BirdMovement()
    {
        if (Input.GetMouseButtonDown(0))
            birdRigidbody.velocity = Vector2.up * jumpSpeed;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ScoreArea"))
            gameManager.UpdateScore();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
            gameManager.GameOver();
    }
}
