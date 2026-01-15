using System;
using Unity.VisualScripting;
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
    [Header("Jump settings")]
    [SerializeField]
    float jumpForce;
    [SerializeField]
    float groundCheckDistance;
    [SerializeField]
    LayerMask groundLayerMask;
    void OnEnable()
    {
        jumpAction.action.started += TryJump;
    }

    void OnDisable()
    {
        jumpAction.action.started -= TryJump;
    }
    bool IsGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, -transform.up, groundCheckDistance, groundLayerMask);
        
        if(raycastHit2D.collider == null)
        {
            // Debug.Log("not Grouneded");
            return false;
        }
        // Debug.Log("Grouneded");
        return true;

    }
    void TryJump(InputAction.CallbackContext obj)
    {
        // Debug.Log("Trying jump!");
        if(IsGrounded())
        {
            Jump();
        }
    }
    void Jump()
    {
        rb.AddForce(jumpForce * transform.up, ForceMode2D.Impulse);
    }
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
        
        Debug.DrawRay(transform.position, -transform.up * groundCheckDistance, Color.red);
    }
}
