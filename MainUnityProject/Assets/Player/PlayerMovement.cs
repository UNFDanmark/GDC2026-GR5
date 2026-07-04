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

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }
    void Update()
    {
        // Calculate Player Movement
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        Vector3 moveRelative = new Vector3(moveInput.x, 0f, moveInput.y)*speed;

        rb.AddRelativeForce(moveRelative);

    }
}
