using System;
using UnityEngine;

public class DeskDrawer1 : MonoBehaviour
{
    bool IsOpening = false;
    public float OpenningDistance;
    public float TimeToOpen = 3;
    float TimeToOpenLeft;  
    Vector3 StartPos;
    Vector3 EndPos;
    
    public void Start()
    {
        StartPos = transform.position;
        EndPos = StartPos + transform.right * OpenningDistance;
        
    }

    public void Open()
    { 
        IsOpening = true;
        TimeToOpenLeft = TimeToOpen;
    }

    public void Update()
    {
        if (IsOpening)
        {
            TimeToOpenLeft = TimeToOpenLeft - Time.deltaTime;
            float PercentToClosed = TimeToOpenLeft/TimeToOpen;
            Vector3 NewPosUpdate = Vector3.Lerp(EndPos, StartPos, PercentToClosed);
            transform.position = NewPosUpdate;
        }
    }
}
