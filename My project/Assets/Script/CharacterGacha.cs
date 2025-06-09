using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using TMPro;
using UnityEngine.TextCore.Text;
using UnityEditor.Experimental.GraphView;
public class CharacterGacha : MonoBehaviour
{
    public TextMeshProUGUI Txt_Bumin;
    List<string> PickUpCharacterList = new List<string>() { "픽업 캐릭터A" };
    List<string> CharacterListSSS = new List<string>() { "5성 상시A", "5성 상시B", "5성 상시C", "5성 상시D" };
    List<string> CharacterListAAA = new List<string>() { "4성 상시E", "4성 상시F", "4성 상시G", "4성 상시H" };
    List<string> CharacterListBBB = new List<string>() { "3성 상시I", "3성 상시J", "3성 상시K", "3성 상시L" };
    public void PlayGacha()
    {
        int CountGacha = 0; // 총 가챠 횟수
        bool CountFloor = false; // 천장 여부 (True면 천장 쳤음, false면 천장이 아님)

        for (int i = 0; i < 10; i++)
        {
            int randomvalue = Random.Range(1, 101); //1이상 101 미만의 숫자
            Debug.Log("랜덤 숫자는 " + randomvalue + " 입니다.");

            if (CountGacha >= 80) // 반천장 (80회)
            {
                int randomvalue2 = Random.Range(1, 3); //1과 2 (50%의 확률)로 픽뚫
                if (randomvalue2 == 1) //50%확률로 픽업 획득
                {
                    Debug.Log("천장으로 픽업 캐릭터 " + PickUpCharacterList[0] + "를 획득했습니다.");
                    CountGacha = 0;
                    CountFloor = false;
                }
                else if (randomvalue2 == 2) //50%확률로 픽뚫
                {
                    int randomvalue3 = Random.Range(0,4);
                    Debug.Log("픽뚫로 " + CharacterListSSS[randomvalue3] + "캐릭터를 획득했습니다.");
                    CountFloor = true;
                }
            }
            else if(CountGacha >= 160 && CountFloor == true) // 풀천장 (160회)
            {
                Debug.Log("풀천장으로 픽업 캐릭터 " + PickUpCharacterList[0] + "를 획득했습니다.");
                CountGacha = 0;
                CountFloor = false;
            }
            else if (randomvalue <= 10) //기본 확률로 픽업 캐릭터 획득
            {
                int randomvalue2 = Random.Range(1, 3); //1과 2 (50%의 확률)로 픽뚫
                if (randomvalue2 == 1)
                {
                    Debug.Log("기본확률로 픽업 캐릭터 " + PickUpCharacterList[0] + "를 획득했습니다.");
                    CountFloor = false;
                    CountGacha = 0;
                }
                else if (randomvalue2 == 2)
                {
                    int randomvalue3 = Random.Range(0, 4);
                    Debug.Log("픽뚫로 " + CharacterListSSS[randomvalue3] + "캐릭터를 획득했습니다.");
                    CountFloor = true;
                    CountGacha = 0;
                }
            }
            else if (randomvalue <= 30) // 4성 캐릭터 획득
            {
                int randomvalue3 = Random.Range(0, 4);
                Debug.Log(CharacterListAAA[randomvalue3] + "를 획득했습니다.");
            }
            else // 3성 캐릭터 획득
            {
                int randomvalue3 = Random.Range(0, 4);
                Debug.Log(CharacterListBBB[randomvalue3] + "를 획득했습니다.");
            }
            CountGacha++;
        }
    }

    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
