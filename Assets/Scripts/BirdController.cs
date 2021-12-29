using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdRigidbody;
    [SerializeField] private float jumpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            birdRigidbody.velocity = Vector2.up * jumpSpeed;
        }
    }
}
