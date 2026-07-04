using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    // Declare Movement Variables
    public InputAction moveAction;
    public float speed;
    Rigidbody rb;
    
    
    void Start()
    {
        // Enable Movement
        moveAction.Enable();
        rb = GetComponent<Rigidbody>();
        
        // Set Movement Speed
        speed = 10;
       
    }
    void Update()
    {
        // Calculate Player Movement
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        Vector3 newVelocity = rb.linearVelocity;
        
        newVelocity.x = moveInput.x * speed; 
        newVelocity.z = moveInput.y * speed;

        rb.linearVelocity = newVelocity;

    }
}
