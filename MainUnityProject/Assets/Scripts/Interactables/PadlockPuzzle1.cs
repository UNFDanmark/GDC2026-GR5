using System;
using TMPro;
using UnityEngine;

public class PadlockPuzzle1 : MonoBehaviour
{
    float txt1 = 0;
    float txt2 = 0;
    float txt3 = 0;
    float txt4 = 0;

    public TextMeshProUGUI display1;
    public TextMeshProUGUI display2;
    public TextMeshProUGUI display3;
    public TextMeshProUGUI display4;
    
    float check = 0.5f;
    bool haveSolved;
    
    public AudioSource lockUnlockSound;

    public GameObject puzzleBox;
    public GameObject puzzleBoxUI;
    public GameObject player;
    public GameObject mainBox;

    void Start()
    {
        display1.text = txt1.ToString();
        display2.text = txt2.ToString();
        display3.text = txt3.ToString();
        display4.text = txt4.ToString();
    }

    public void IncreaseTxt1()
    {
        txt1 += 1;
        txt1 = Mathf.Repeat(txt1, 10);
        display1.text = txt1.ToString();
        
    }
    
    public void IncreaseTxt2()
    {
        txt2 += 1;
        txt2 = Mathf.Repeat(txt2, 10);
        display2.text = txt2.ToString();
    }
    
    public void IncreaseTxt3()
    {
        txt3 += 1;
        txt3 = Mathf.Repeat(txt3, 10);
        display3.text = txt3.ToString();
    }
    
    public void IncreaseTxt4()
    {
        txt4 += 1;
        txt4 = Mathf.Repeat(txt4, 10);
        display4.text = txt4.ToString();
    }

    void Update()
    {
        if (!haveSolved)
        {
            if (txt1 == 1 && txt2 == 7 && txt3 == 0 && txt4 == 3)
            {
                check -= Time.deltaTime;

                if (check <= 0)
                {
                    check = 0.5f;
                    haveSolved = true;
                    lockUnlockSound.Play();
                    player.GetComponent<Interaction>().ExitInteractableUI();
                    puzzleBoxUI.SetActive(false);
                    puzzleBox.SetActive(false);
                    mainBox.gameObject.layer = LayerMask.NameToLayer("Funiture");
                }
            }
            else
            {
                check = 0.5f;
            }
            
        }
    }
}