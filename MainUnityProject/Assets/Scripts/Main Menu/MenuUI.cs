using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public GameObject Black; // Screen 0
    public GameObject Logo; // Screen 1
    public GameObject Lore1; // Screen 2
    public GameObject Lore2; // Screen 3
    float speed;
    float cooldownLeft;
    int screen = 0;

    void Update()
    {
        
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Manor Room 1");
    }
    
    
}
