using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;
    private Vector2 _smoothMovementInput;
    private Vector2 _movementInputSmoothVelocity;

    [SerializeField]
    private float _speed;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        _smoothMovementInput = Vector2.SmoothDamp(_smoothMovementInput, _movementInput, ref _movementInputSmoothVelocity, 0.1f);

        _rigidbody.linearVelocity = _smoothMovementInput * _speed;


    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>();
    }
}
