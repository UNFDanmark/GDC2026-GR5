using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{

    // Declare Camera Movement Variables
    public InputAction turnAction;
    public float sensitivity;
    GameObject go;
    float yaw;
    float pitch;
    public Transform camera;
    public Interaction InteractionUIBorrowed;
    
    
    void Start()
    {
        // Enable Camera Movement
        turnAction.Enable();
        go = GetComponent<GameObject>();
       
    }
    void Update()
    {
        if (InteractionUIBorrowed.isInInteractableUI)
            return;
        
        
        // Calculate Camera Movement
        Vector2 moveInput = turnAction.ReadValue<Vector2>();
        pitch += moveInput.y * -sensitivity * Time.deltaTime;
        yaw += moveInput.x * sensitivity * Time.deltaTime;

        // Anti Neck Breaking
        pitch = Mathf.Clamp(pitch, -85f, 85f);
        yaw = Mathf.Repeat(yaw, 360);

        // Set Rotation
        transform.rotation = Quaternion.Euler(0f, yaw, 0f);
        camera.localRotation = Quaternion.Euler(pitch, 0f, 0f);
        

    }
}