using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class AgentMovement : MonoBehaviour
{

    protected Rigidbody2D newRigidBody2D;

    [field: SerializeField]
    public MovementDataSO MovementData { get; set; }

    [SerializeField] protected float currentVelocity = 3;

    protected Vector2 movementDirection;

    [field: SerializeField]
    public UnityEvent<float> OnVelocityChanged { get; set; }

    private void Awake()
    {
        newRigidBody2D = GetComponent<Rigidbody2D>();
    }

    public void MoveAgent(Vector2 movementInput)
    {
        movementDirection = movementInput;
        currentVelocity = CalculateSpeed(movementInput);

    }

    private float CalculateSpeed(Vector2 movementInput)
    {
        if (movementInput.magnitude > 0)
        {
            currentVelocity += MovementData.accelaration * Time.deltaTime;
        }
        else
        {
            currentVelocity -= MovementData.deaccelaration * Time.deltaTime;
        }

        return Mathf.Clamp(currentVelocity, 0, MovementData.maxSpeed);
    }

    private void FixedUpdate()
    {
        OnVelocityChanged?.Invoke(currentVelocity);
        newRigidBody2D.velocity = currentVelocity * movementDirection.normalized;
    }
}
