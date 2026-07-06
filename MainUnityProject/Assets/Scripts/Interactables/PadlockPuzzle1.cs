using System;
using TMPro;
using UnityEngine;

public class PadlockPuzzle1 : MonoBehaviour
{
    float txt1 = 0;
    float txt2 = 0;
    float txt3 = 0;

    public TextMeshProUGUI display1;
    public TextMeshProUGUI display2;
    public TextMeshProUGUI display3;
    
    float check = 0.5f;
    bool haveSolved;

    void Start()
    {
        display1.text = txt1.ToString();
        display2.text = txt2.ToString();
        display3.text = txt3.ToString();
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

    void Update()
    {
        if (!haveSolved)
        {
            if (txt1 == 4 && txt2 == 7 && txt3 == 2)
            {
                check -= Time.deltaTime;

                if (check <= 0)
                {
                    print("Lock Opened!");
                    check = 0.5f;
                    haveSolved = true;
                }
            }
            else
            {
                check = 0.5f;
            }
            
        }
    }
}