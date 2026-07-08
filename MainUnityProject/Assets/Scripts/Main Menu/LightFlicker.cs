using System;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using Random = System.Random;

public class LightFlicker : MonoBehaviour
{
    public GameObject candlePointLight;
    bool lightState;
    float cldwn;
    float cldwnReset = 0.07f;
    Light light;

    void Start()
    {
        light = candlePointLight.GetComponent<Light>();
    }

    void Update()
    {
        cldwn -= Time.deltaTime;
        
        if (cldwn <= 0)
        {
            if (lightState == false)
            {
                light.intensity = UnityEngine.Random.Range(0.8f,1.15f);
                lightState = true;
                cldwn = cldwnReset;
            } else if (lightState)
            {
                light.intensity = UnityEngine.Random.Range(0.8f,1.15f);
                lightState = false;
                cldwn = cldwnReset;
            }


            
        }
    }
}
