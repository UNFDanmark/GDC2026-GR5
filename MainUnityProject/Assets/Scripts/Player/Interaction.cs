using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    bool hitSomething;
    RaycastHit hit;

    public float interactionDistance = 8f;

    public Transform camera;

    public InputAction interactionAction;

    public GameObject e;
    public GameObject paperClue1;
    public GameObject padlockPuzzle1;
    public bool isInInteractableUI;


    void Start()
    {
        interactionAction.Enable();
    }

    public void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ExitInteractableUI()
    {
        isInInteractableUI = false;
        LockCursor();
    }
    
    void Update()
    {
        var myLayer = LayerMask.GetMask("Interactables");
        hitSomething = Physics.Raycast(camera.position, camera.forward, out hit, interactionDistance, myLayer);

        if (hitSomething)
        {
            e.SetActive(true);
            
            if (interactionAction.WasPerformedThisFrame())
            {
                isInInteractableUI = true;
                
                if (hit.transform.CompareTag("PaperClue1"))
                {
                    paperClue1.SetActive(true);
                    UnlockCursor();
                    
                }

                if (hit.transform.CompareTag("PadlockPuzzle1"))
                {
                    padlockPuzzle1.SetActive(true);
                    UnlockCursor();
                }
            }
        }
        else
        {
            e.SetActive(false);
            
        }
    }

    void OnDrawGizmos()
    {
        if (hitSomething)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }
        Gizmos.DrawRay(camera.position,camera.forward*interactionDistance);
    }
}
