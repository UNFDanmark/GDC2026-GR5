using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    // Declare Movement Variables
    public InputAction moveAction;
    public float speed;
    Rigidbody rb;
    public float crouchSpeed;
    public InputAction crouchAction;
    public Interaction InteractionUIBorrowed;
    public float playerSize;
    
    
    void Start()
    {
        // Enable Movement
        moveAction.Enable();
        crouchAction.Enable();
        rb = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }
    void Update()
    {
        if (InteractionUIBorrowed.isInInteractableUI)
            return;
        
        
        // Calculate Player Movement
        Vector2 moveInput = moveAction.ReadValue<Vector2>();

        if (crouchAction.IsPressed())
        {
            Vector3 moveRelative = new Vector3(moveInput.x, 0f, moveInput.y)*crouchSpeed;    
            rb.AddRelativeForce(moveRelative);
        }
        else
        {
            Vector3 moveRelative = new Vector3(moveInput.x, 0f, moveInput.y)*speed;
            rb.AddRelativeForce(moveRelative);
            
            
        }

        if (crouchAction.WasPerformedThisFrame())
        {
            Vector3 currentScale = transform.localScale; 
            currentScale.y = playerSize / 2;
            transform.localScale = currentScale;

        }
        else if (crouchAction.WasReleasedThisFrame())
        {
            Vector3 currentScale = transform.localScale; 
            currentScale.y = playerSize;
            transform.localScale = currentScale;
            
        }
        

    }


}
