using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        //페이즈 1

        for (int a = 1; a < 6; a++)
        {
            for (int b = 0; b < 5; b++)
            {
                if (a > b)
                    star += "★";
                else
                    star += "　";
            }
            star += "\n";
        }


        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2
        for (int a = 0;a < 5;a++)
        {
            for(int b = 0;b < 5;b++)
            {
                if (a > b)
                    star += "　";
                else
                    star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;
        // 페이즈 3
        for (int a = 1; a < 10; a++)
        {
            for (int b = 0; b < 5; b++)
            {
                if (a > b)
                    star += "★";
                else if (a>5)
                {
                    int c = a % 5;
                    
                }
                else
                    star += "　";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5


        Debug.Log(star);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
