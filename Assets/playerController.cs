using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class playerController : MonoBehaviour
{
    [SerializeField] InputActionReference moveAction, jumpAction;
    Rigidbody2D rb;
    [SerializeField]
    float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 input = moveAction.action.ReadValue<Vector2>();
        input = input * Time.deltaTime * moveSpeed;
        rb.AddForce(input, ForceMode2D.Force);
        // TODO clamp to max speed
        // TODO change based on 
        
    }
}
