using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public float musicCooldown;
    public float cooldownRandomization;
    float cooldownLeft;
    float calcRandom; 

    void Start()
    {
        cooldownLeft = musicCooldown;
    }

    void Update()
    {
        if (audioSource.isPlaying)
        {
            calcRandom = Random.Range(0, cooldownRandomization);
        }

        if (!audioSource.isPlaying)
        {
            cooldownLeft -= Time.deltaTime * calcRandom;

            if (cooldownLeft <= 0)
            {
                audioSource.Play();
                cooldownLeft = musicCooldown;
            }
        }
    }
}
