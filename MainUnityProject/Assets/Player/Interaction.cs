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
            if (interactionAction.WasPerformedThisFrame())
            {
                if (hit.transform.CompareTag("PaperClue1"))
                {
                    print("PaperClue1 found!");
                }

                if (hit.transform.CompareTag("ChestPuzzle1"))
                {
                    print("ChestPuzzle1 found!");
                }
            }
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
