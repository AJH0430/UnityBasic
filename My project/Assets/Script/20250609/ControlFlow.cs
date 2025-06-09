using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    int count;

    void Awake()
    {
        count = 0;
    }


    //private 생략되어 있다.
    void Start()
    {
        
    }
    // [심화 : 업 다운]
    // 랜덤한 수 1~100 사이에 값을 만들고 
    // Input Field에 입력된 값이
    // 랜덤한 값보다 크면 "크다", 작으면 "작다"
    // Count 증가
    // 결과적으로 몇번만에


    // Start is called before the first frame update
    public int selectNumbe = 0;
    public void GachaSwitch()
    {        
        switch(selectNumbe)
        {
            case 0:
                {
                    for (int i = 0; i < 10; i++)
                    {
                        int randomValue = Random.Range(0, 101); // 1이상 100미만의 랜덤한 값을 받아 오겠다. (1~100)
                        //은색 머리가 캐릭터가 나온다
                        if (randomValue <= 10)
                        {
                            Debug.Log("'은색 머리'를 뽑았다!");                
                        }
                        else if (randomValue <= 30)
                        {
                            Debug.Log("'모나'를 뽑았다!");                            
                        }
                        else
                        {
                            Debug.Log("'치치'를 뽑았다");                            
                        }
                    }
                }
                break;
            case 1:
                {
                    int randomValue = Random.Range(0, 101); // 1이상 100미만의 랜덤한 값을 받아 오겠다. (1~100)
                    if (randomValue <= 10)
                    {
                        Debug.Log("'파란 머리'를 뽑았다!");
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'모나'를 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑았다");
                    }
                }
                
                break;
            case 2:
                {
                    int randomValue = Random.Range(0, 101); // 1이상 100미만의 랜덤한 값을 받아 오겠다. (1~100)
                    if (randomValue <= 10)
                    {
                        Debug.Log("'빨간 머리'를 뽑았다!");
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'모나'를 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑았다");
                    }
                }
                
                break;
            default :
                {
                    int randomValue = Random.Range(0, 101); // 1이상 100미만의 랜덤한 값을 받아 오겠다. (1~100)
                    if (randomValue <= 10)
                    {
                        Debug.Log("'초록 머리'를 뽑았다!");
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'모나'를 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑았다");
                    }
                }
                
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}