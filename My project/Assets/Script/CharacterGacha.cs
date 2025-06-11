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

    public TextMeshProUGUI[] Txt_ShowCharacter = new TextMeshProUGUI[10]; // 10���� ���� ĳ���͸� �����ִ� �ؽ�Ʈ

    public TextMeshProUGUI Txt_ShowCharacterOnlyOne;

    List<string> PickUpCharacterList = new List<string>() { "�Ⱦ� ĳ����" };
    List<string> CharacterListSSS = new List<string>() { "5�� ���A", "5�� ���B", "5�� ���C", "5�� ���D" };
    List<string> CharacterListAAA = new List<string>() { "4�� E", "4�� F", "4�� G", "4�� H" };
    List<string> CharacterListBBB = new List<string>() { "3�� I", "3�� J", "3�� K", "3�� L" };



    int CountGacha = 0; // �� ��í Ƚ��
    bool CountFloor = false; // ��õ�� ���� (True�� ��õ�� ����, false�� ��õ���� �ƴ�)

    public void PlayGacha() //10���� �Լ�
    {
        for (int i = 0; i < 10; i++)
        {
            int randomvalue = Random.Range(1, 101); //1�̻� 101 �̸��� ����
            Debug.Log("���� ���ڴ� " + randomvalue + " �Դϴ�.");

            if (CountGacha >= 79 && CountFloor == false) // ��õ�� (80ȸ)
            {
                int randomvalue2 = Random.Range(1, 3); //1�� 2 (50%�� Ȯ��)�� �ȶ�
                if (randomvalue2 == 1) //50%Ȯ���� �Ⱦ� ȹ��
                {
                    Debug.Log("��õ������ �Ⱦ� ĳ���� " + PickUpCharacterList[0] + "�� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@");
                    CountGacha = 0;
                    CountFloor = false;
                    Txt_ShowCharacter[i].text = PickUpCharacterList[0]; //ȭ�鿡 ǥ��
                }
                else if (randomvalue2 == 2) //50%Ȯ���� �ȶ�
                {
                    int randomvalue3 = Random.Range(0, 4);
                    Debug.Log("��õ�� �ȶշ� " + CharacterListSSS[randomvalue3] + "ĳ���͸� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@@");
                    CountFloor = true;
                    Txt_ShowCharacter[i].text = CharacterListSSS[randomvalue3];
                }
            }
            else if (CountGacha >= 159 && CountFloor == true) // Ǯõ�� (160ȸ) -> Ȯ�� �Ⱦ� ȹ��
            {
                Debug.Log("Ǯõ������ �Ⱦ� ĳ���� " + PickUpCharacterList[0] + "�� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@@@@@");
                CountGacha = 0;
                CountFloor = false;
                Txt_ShowCharacter[i].text = PickUpCharacterList[0];
            }
            else if (randomvalue <= 1) //�⺻ Ȯ���� �Ⱦ� ĳ���� ȹ��
            {
                int randomvalue2 = Random.Range(1, 3); //1�� 2 (50%�� Ȯ��)�� �ȶ�

                if (CountFloor == true) // ���� �ȶ� + �⺻Ȯ�� 5���� ��� Ȯ�� �Ⱦ�
                {
                    Debug.Log("�⺻Ȯ�� + ������ �ȶ��߱� ������ Ȯ������ " + PickUpCharacterList[0] + "�� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@@");
                    CountFloor = false;
                    CountGacha = 0;
                }

                else if (randomvalue2 == 1)
                {
                    Debug.Log("�⺻Ȯ���� �Ⱦ� ĳ���� " + PickUpCharacterList[0] + "�� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@@@@@@");
                    CountFloor = false;
                    CountGacha = 0;
                    Txt_ShowCharacter[i].text = PickUpCharacterList[0];
                }
                else
                {
                    int randomvalue3 = Random.Range(0, 4); // 0,1,2,3 ����Ʈ ������
                    Debug.Log("�ȶշ� " + CharacterListSSS[randomvalue3] + "ĳ���͸� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@@@@@@");
                    CountFloor = true;
                    Txt_ShowCharacter[i].text = CharacterListSSS[randomvalue3];
                }
            }
            else if (randomvalue <= 20) // 4�� ĳ���� ȹ��
            {
                int randomvalue3 = Random.Range(0, 4);
                Debug.Log(CharacterListAAA[randomvalue3] + "�� ȹ���߽��ϴ�.");
                Txt_ShowCharacter[i].text = CharacterListAAA[randomvalue3];
            }
            else // 3�� ĳ���� ȹ��
            {
                int randomvalue3 = Random.Range(0, 4);
                Debug.Log(CharacterListBBB[randomvalue3] + "�� ȹ���߽��ϴ�.");
                Txt_ShowCharacter[i].text = CharacterListBBB[randomvalue3];
            }
            CountGacha++;
        }
        Txt_CountGacha.text = CountGacha + "ȸ";


    }
    // for ������ 10���� ����
    // ���� �Լ��� Ȯ�� ����
    // ����Ʈ ������ �̾Ƽ� ����ϴ°� ����
    public void PlayGachaOnlyOne()
    {

        int randomvalue = Random.Range(1, 101); //1�̻� 101 �̸��� ����
        Debug.Log("���� ���ڴ� " + randomvalue + " �Դϴ�.");

        if (CountGacha >= 79 && CountFloor == false) // ��õ�� (80ȸ)
        {
            int randomvalue2 = Random.Range(1, 3); //1�� 2 (50%�� Ȯ��)�� �ȶ�
            if (randomvalue2 == 1) //50%Ȯ���� �Ⱦ� ȹ��
            {
                Debug.Log("��õ������ �Ⱦ� ĳ���� " + PickUpCharacterList[0] + "�� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@");
                CountGacha = 0;
                CountFloor = false;
                Txt_ShowCharacterOnlyOne.text = PickUpCharacterList[0]; //ȭ�鿡 ǥ��
            }
            else if (randomvalue2 == 2) //50%Ȯ���� �ȶ�
            {
                int randomvalue3 = Random.Range(0, 4);
                Debug.Log("��õ�� �ȶշ� " + CharacterListSSS[randomvalue3] + "ĳ���͸� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@@");
                CountFloor = true;
                Txt_ShowCharacterOnlyOne.text = CharacterListSSS[randomvalue3];
            }
        }
        else if (CountGacha >= 159 && CountFloor == true) // Ǯõ�� (160ȸ) -> Ȯ�� �Ⱦ� ȹ��
        {
            Debug.Log("Ǯõ������ �Ⱦ� ĳ���� " + PickUpCharacterList[0] + "�� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@@@@@");
            CountGacha = 0;
            CountFloor = false;
            Txt_ShowCharacterOnlyOne.text = PickUpCharacterList[0];
        }
        else if (randomvalue <= 1) //�⺻ Ȯ���� �Ⱦ� ĳ���� ȹ��
        {
            int randomvalue2 = Random.Range(1, 3); //1�� 2 (50%�� Ȯ��)�� �ȶ�

            if (CountFloor == true) // ���� �ȶ� + �⺻Ȯ�� 5���� ��� Ȯ�� �Ⱦ�
            {
                Debug.Log("�⺻Ȯ�� + ������ �ȶ��߱� ������ Ȯ������ " + PickUpCharacterList[0] + "�� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@@");
                CountFloor = false;
                CountGacha = 0;
            }

            else if (randomvalue2 == 1)
            {
                Debug.Log("�⺻Ȯ���� �Ⱦ� ĳ���� " + PickUpCharacterList[0] + "�� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@@@@@@");
                CountFloor = false;
                CountGacha = 0;
                Txt_ShowCharacterOnlyOne.text = PickUpCharacterList[0];
            }
            else
            {
                int randomvalue3 = Random.Range(0, 4); // 0,1,2,3 ����Ʈ ������
                Debug.Log("�ȶշ� " + CharacterListSSS[randomvalue3] + "ĳ���͸� ȹ���߽��ϴ�.@@@@@@@@@@@@@@@@@@@@@@");
                CountFloor = true;
                CountGacha = 0;
                Txt_ShowCharacterOnlyOne.text = CharacterListSSS[randomvalue3];
            }
        }
        else if (randomvalue <= 20) // 4�� ĳ���� ȹ��
        {
            int randomvalue3 = Random.Range(0, 4);
            Debug.Log(CharacterListAAA[randomvalue3] + "�� ȹ���߽��ϴ�.");
            Txt_ShowCharacterOnlyOne.text = CharacterListAAA[randomvalue3];
        }
        else // 3�� ĳ���� ȹ��
        {
            int randomvalue3 = Random.Range(0, 4);
            Debug.Log(CharacterListBBB[randomvalue3] + "�� ȹ���߽��ϴ�.");
            Txt_ShowCharacterOnlyOne.text = CharacterListBBB[randomvalue3];
        }
        CountGacha++;

        Txt_CountGacha.text = CountGacha + "ȸ";

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