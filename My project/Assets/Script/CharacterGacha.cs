using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using TMPro;
using UnityEngine.TextCore.Text;
using UnityEditor.Experimental.GraphView;
public class CharacterGacha : MonoBehaviour
{
    public TextMeshProUGUI Txt_CountGacha;

    public TextMeshProUGUI[] Txt_ShowCharacter = new TextMeshProUGUI[10]; // 10연차 뽑은 캐릭터를 보여주는 텍스트

    public TextMeshProUGUI Txt_ShowCharacterOnlyOne;

    List<string> PickUpCharacterList = new List<string>() { "픽업 캐릭터" };
    List<string> CharacterListSSS = new List<string>() { "5성 상시A", "5성 상시B", "5성 상시C", "5성 상시D" };
    List<string> CharacterListAAA = new List<string>() { "4성 E", "4성 F", "4성 G", "4성 H" };
    List<string> CharacterListBBB = new List<string>() { "3성 I", "3성 J", "3성 K", "3성 L" };



    int CountGacha = 0; // 총 가챠 횟수
    bool CountFloor = false; // 반천장 여부 (True면 반천장 쳤음, false면 반천장이 아님)

    public void PlayGacha() //10연차 함수
    {
        for (int i = 0; i < 10; i++)
        {
            int randomvalue = Random.Range(1, 101); //1이상 101 미만의 숫자
            Debug.Log("랜덤 숫자는 " + randomvalue + " 입니다.");

            if (CountGacha >= 79 && CountFloor == false) // 반천장 (80회)
            {
                int randomvalue2 = Random.Range(1, 3); //1과 2 (50%의 확률)로 픽뚫
                if (randomvalue2 == 1) //50%확률로 픽업 획득
                {
                    Debug.Log("반천장으로 픽업 캐릭터 " + PickUpCharacterList[0] + "를 획득했습니다.@@@@@@@@@@@@@@@@@");
                    CountGacha = 0;
                    CountFloor = false;
                    Txt_ShowCharacter[i].text = PickUpCharacterList[0]; //화면에 표시
                }
                else if (randomvalue2 == 2) //50%확률로 픽뚫
                {
                    int randomvalue3 = Random.Range(0, 4);
                    Debug.Log("반천장 픽뚫로 " + CharacterListSSS[randomvalue3] + "캐릭터를 획득했습니다.@@@@@@@@@@@@@@@@@@");
                    CountFloor = true;
                    Txt_ShowCharacter[i].text = CharacterListSSS[randomvalue3];
                }
            }
            else if (CountGacha >= 159 && CountFloor == true) // 풀천장 (160회) -> 확정 픽업 획득
            {
                Debug.Log("풀천장으로 픽업 캐릭터 " + PickUpCharacterList[0] + "를 획득했습니다.@@@@@@@@@@@@@@@@@@@@@");
                CountGacha = 0;
                CountFloor = false;
                Txt_ShowCharacter[i].text = PickUpCharacterList[0];
            }
            else if (randomvalue <= 1) //기본 확률로 픽업 캐릭터 획득
            {
                int randomvalue2 = Random.Range(1, 3); //1과 2 (50%의 확률)로 픽뚫

                if (CountFloor == true) // 기존 픽뚫 + 기본확률 5성일 경우 확정 픽업
                {
                    Debug.Log("기본확률 + 기존에 픽뚫했기 때문에 확정으로 " + PickUpCharacterList[0] + "를 획득했습니다.@@@@@@@@@@@@@@@@@@");
                    CountFloor = false;
                    CountGacha = 0;
                }

                else if (randomvalue2 == 1)
                {
                    Debug.Log("기본확률로 픽업 캐릭터 " + PickUpCharacterList[0] + "를 획득했습니다.@@@@@@@@@@@@@@@@@@@@@@");
                    CountFloor = false;
                    CountGacha = 0;
                    Txt_ShowCharacter[i].text = PickUpCharacterList[0];
                }
                else
                {
                    int randomvalue3 = Random.Range(0, 4); // 0,1,2,3 리스트 데이터
                    Debug.Log("픽뚫로 " + CharacterListSSS[randomvalue3] + "캐릭터를 획득했습니다.@@@@@@@@@@@@@@@@@@@@@@");
                    CountFloor = true;
                    Txt_ShowCharacter[i].text = CharacterListSSS[randomvalue3];
                }
            }
            else if (randomvalue <= 20) // 4성 캐릭터 획득
            {
                int randomvalue3 = Random.Range(0, 4);
                Debug.Log(CharacterListAAA[randomvalue3] + "를 획득했습니다.");
                Txt_ShowCharacter[i].text = CharacterListAAA[randomvalue3];
            }
            else // 3성 캐릭터 획득
            {
                int randomvalue3 = Random.Range(0, 4);
                Debug.Log(CharacterListBBB[randomvalue3] + "를 획득했습니다.");
                Txt_ShowCharacter[i].text = CharacterListBBB[randomvalue3];
            }
            CountGacha++;
        }
        Txt_CountGacha.text = CountGacha + "회";


    }
    // for 문으로 10연차 구현
    // 랜덤 함수로 확률 구현
    // 리스트 데이터 뽑아서 출력하는거 구현
    public void PlayGachaOnlyOne()
    {

        int randomvalue = Random.Range(1, 101); //1이상 101 미만의 숫자
        Debug.Log("랜덤 숫자는 " + randomvalue + " 입니다.");

        if (CountGacha >= 79 && CountFloor == false) // 반천장 (80회)
        {
            int randomvalue2 = Random.Range(1, 3); //1과 2 (50%의 확률)로 픽뚫
            if (randomvalue2 == 1) //50%확률로 픽업 획득
            {
                Debug.Log("반천장으로 픽업 캐릭터 " + PickUpCharacterList[0] + "를 획득했습니다.@@@@@@@@@@@@@@@@@");
                CountGacha = 0;
                CountFloor = false;
                Txt_ShowCharacterOnlyOne.text = PickUpCharacterList[0]; //화면에 표시
            }
            else if (randomvalue2 == 2) //50%확률로 픽뚫
            {
                int randomvalue3 = Random.Range(0, 4);
                Debug.Log("반천장 픽뚫로 " + CharacterListSSS[randomvalue3] + "캐릭터를 획득했습니다.@@@@@@@@@@@@@@@@@@");
                CountFloor = true;
                Txt_ShowCharacterOnlyOne.text = CharacterListSSS[randomvalue3];
            }
        }
        else if (CountGacha >= 159 && CountFloor == true) // 풀천장 (160회) -> 확정 픽업 획득
        {
            Debug.Log("풀천장으로 픽업 캐릭터 " + PickUpCharacterList[0] + "를 획득했습니다.@@@@@@@@@@@@@@@@@@@@@");
            CountGacha = 0;
            CountFloor = false;
            Txt_ShowCharacterOnlyOne.text = PickUpCharacterList[0];
        }
        else if (randomvalue <= 1) //기본 확률로 픽업 캐릭터 획득
        {
            int randomvalue2 = Random.Range(1, 3); //1과 2 (50%의 확률)로 픽뚫

            if (CountFloor == true) // 기존 픽뚫 + 기본확률 5성일 경우 확정 픽업
            {
                Debug.Log("기본확률 + 기존에 픽뚫했기 때문에 확정으로 " + PickUpCharacterList[0] + "를 획득했습니다.@@@@@@@@@@@@@@@@@@");
                CountFloor = false;
                CountGacha = 0;
            }

            else if (randomvalue2 == 1)
            {
                Debug.Log("기본확률로 픽업 캐릭터 " + PickUpCharacterList[0] + "를 획득했습니다.@@@@@@@@@@@@@@@@@@@@@@");
                CountFloor = false;
                CountGacha = 0;
                Txt_ShowCharacterOnlyOne.text = PickUpCharacterList[0];
            }
            else
            {
                int randomvalue3 = Random.Range(0, 4); // 0,1,2,3 리스트 데이터
                Debug.Log("픽뚫로 " + CharacterListSSS[randomvalue3] + "캐릭터를 획득했습니다.@@@@@@@@@@@@@@@@@@@@@@");
                CountFloor = true;
                CountGacha = 0;
                Txt_ShowCharacterOnlyOne.text = CharacterListSSS[randomvalue3];
            }
        }
        else if (randomvalue <= 20) // 4성 캐릭터 획득
        {
            int randomvalue3 = Random.Range(0, 4);
            Debug.Log(CharacterListAAA[randomvalue3] + "를 획득했습니다.");
            Txt_ShowCharacterOnlyOne.text = CharacterListAAA[randomvalue3];
        }
        else // 3성 캐릭터 획득
        {
            int randomvalue3 = Random.Range(0, 4);
            Debug.Log(CharacterListBBB[randomvalue3] + "를 획득했습니다.");
            Txt_ShowCharacterOnlyOne.text = CharacterListBBB[randomvalue3];
        }
        CountGacha++;

        Txt_CountGacha.text = CountGacha + "회";

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