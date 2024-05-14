using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class TopDownMovement : MonoBehaviour //실제 이동 관련
{
    private TopDownController controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate() //물리적으로 움직이는 부분 FixUpdate에서 처리
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5f;
        movementRigidbody.velocity = direction;
    }
}