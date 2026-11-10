using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class Mario : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    [SerializeField]
    private Rigidbody body;

    [SerializeField]
    private InputActionAsset inputActions;

    private InputAction moveAction;

    void Start()
    {
        moveAction = inputActions.FindAction("Player/Move");
        moveAction.Enable();
    }

    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        body.linearVelocity = new Vector3(moveInput.x, 0.0f, moveInput.y) * moveSpeed;
    }
}
