using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ArrayList : MonoBehaviour
{


    int[] numbers = new int[3];

    List<int> numberList = new List<int>();


    public TextMeshProUGUI Txt_bum;
    string[] character = { "정은교", "김한나", "손석현", "이윤호", "엄지성", "신채현", "차정훈", "최현석" };
    List<string> characterList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        numbers[0] = 100;
        numbers[1] = 200;

        numberList.Add(200); //0
        numberList.Add(100); //1
        numberList.Add(300); //2
        numberList.Add(700); //3
        numberList.Add(0); //4
        numberList.Add(500); // 5

        Debug.Log("number : " + numbers[1]);
        Debug.Log("numberList : " + numberList[4]);

        characterList.Add("정은교");
        characterList.Add("김한나");
        characterList.Add("손석현");
        characterList.Add("이윤호");
        characterList.Add("엄지성");
        
    }

    public void ArrayGacha()
    {
        int randomvalue = Random.Range(0, character.Length);

        Debug.Log("범인은?"+character[randomvalue]+"였습니다.");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
