using System;
using UnityEngine;

public class BillBoardFlame : MonoBehaviour
{
    public GameObject Player;
    public GameObject FlameAnimation;

    void Update()
    {
        Vector3 playerPosition = Player.transform.position;
        FlameAnimation.transform.LookAt(playerPosition);

        Vector3 flameRotation = FlameAnimation.transform.rotation.eulerAngles;
        flameRotation.x = 0f;
        FlameAnimation.transform.rotation = Quaternion.Euler(0f, flameRotation.y, flameRotation.z);
    }
}
