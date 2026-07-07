using System;
using UnityEngine;
using UnityEngine.Audio;

public class AmbianceNoice : MonoBehaviour
{
    public AudioSource audioSource;
    public float musicCooldown;
    public float cooldownRandomization;
    float cooldownLeft;
    

    void Update()
    {

        if (!audioSource.isPlaying)
        {
            cooldownLeft -= Time.deltaTime + UnityEngine.Random.Range(0, cooldownRandomization);

            if (cooldownLeft <= 0)
            {
                audioSource.Play();
                cooldownLeft = musicCooldown;
            }
        }
    }
}
