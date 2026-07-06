using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    bool hitSomething;
    RaycastHit hit;

    public float interactionDistance = 8f;
    // bool isInInteractive;

    public Transform camera;

    public InputAction interactionAction;

    public GameObject e;
    public GameObject paperClue1;


    void Start()
    {
        interactionAction.Enable();
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
                if (hit.transform.CompareTag("PaperClue1"))
                {
                    paperClue1.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    
                }

                if (hit.transform.CompareTag("ChestPuzzle1"))
                {
                    print("ChestPuzzle1 found!");
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
