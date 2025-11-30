using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 11f;
    public float horizontalSpeed = 3f;
    public float rightLimit = 7.47f;
    public float leftLimit = -7.47f;

    [HideInInspector] public bool enable = true;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody at start
    }

    void Update()
    {
        if (!enable) return;

        // Calculate movement
        Vector3 moveDirection = Vector3.forward * playerSpeed;

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && transform.position.x > leftLimit)
        {
            moveDirection += Vector3.left * horizontalSpeed;
        }
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && transform.position.x < rightLimit)
        {
            moveDirection += Vector3.right * horizontalSpeed;
        }

        // Move player
        Vector3 newPosition = rb.position + moveDirection * Time.deltaTime;
        newPosition.y = rb.position.y; // Lock Y position

        rb.MovePosition(newPosition);
    }
}
