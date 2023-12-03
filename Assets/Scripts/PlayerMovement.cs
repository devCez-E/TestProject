using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInputController controller;

    private Vector2 movementDirection = Vector2.zero;
    private Rigidbody2D rigidbody;

    private void Awake()
    {
        controller = GetComponent<PlayerInputController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 value)
    {
        value *= 5;
        rigidbody.velocity = value;
    }

    void Update()
    {
        ApplyMovement(movementDirection);
    }
}
