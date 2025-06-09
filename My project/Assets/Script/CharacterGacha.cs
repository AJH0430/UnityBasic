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
    List<string> PickUpCharacterList = new List<string>() { "�Ⱦ� ĳ����A" };
    List<string> CharacterListSSS = new List<string>() { "5�� ���A", "5�� ���B", "5�� ���C", "5�� ���D" };
    List<string> CharacterListAAA = new List<string>() { "4�� ���E", "4�� ���F", "4�� ���G", "4�� ���H" };
    List<string> CharacterListBBB = new List<string>() { "3�� ���I", "3�� ���J", "3�� ���K", "3�� ���L" };
    public void PlayGacha()
    {
        int CountGacha = 0; // �� ��í Ƚ��
        bool CountFloor = false; // õ�� ���� (True�� õ�� ����, false�� õ���� �ƴ�)

        for (int i = 0; i < 10; i++)
        {
            int randomvalue = Random.Range(1, 101); //1�̻� 101 �̸��� ����
            Debug.Log("���� ���ڴ� " + randomvalue + " �Դϴ�.");

            if (CountGacha >= 80) // ��õ�� (80ȸ)
            {
                int randomvalue2 = Random.Range(1, 3); //1�� 2 (50%�� Ȯ��)�� �ȶ�
                if (randomvalue2 == 1) //50%Ȯ���� �Ⱦ� ȹ��
                {
                    Debug.Log("õ������ �Ⱦ� ĳ���� " + PickUpCharacterList[0] + "�� ȹ���߽��ϴ�.");
                    CountGacha = 0;
                    CountFloor = false;
                }
                else if (randomvalue2 == 2) //50%Ȯ���� �ȶ�
                {
                    int randomvalue3 = Random.Range(0,4);
                    Debug.Log("�ȶշ� " + CharacterListSSS[randomvalue3] + "ĳ���͸� ȹ���߽��ϴ�.");
                    CountFloor = true;
                }
            }
            else if(CountGacha >= 160 && CountFloor == true) // Ǯõ�� (160ȸ)
            {
                Debug.Log("Ǯõ������ �Ⱦ� ĳ���� " + PickUpCharacterList[0] + "�� ȹ���߽��ϴ�.");
                CountGacha = 0;
                CountFloor = false;
            }
            else if (randomvalue <= 10) //�⺻ Ȯ���� �Ⱦ� ĳ���� ȹ��
            {
                int randomvalue2 = Random.Range(1, 3); //1�� 2 (50%�� Ȯ��)�� �ȶ�
                if (randomvalue2 == 1)
                {
                    Debug.Log("�⺻Ȯ���� �Ⱦ� ĳ���� " + PickUpCharacterList[0] + "�� ȹ���߽��ϴ�.");
                    CountFloor = false;
                    CountGacha = 0;
                }
                else if (randomvalue2 == 2)
                {
                    int randomvalue3 = Random.Range(0, 4);
                    Debug.Log("�ȶշ� " + CharacterListSSS[randomvalue3] + "ĳ���͸� ȹ���߽��ϴ�.");
                    CountFloor = true;
                    CountGacha = 0;
                }
            }
            else if (randomvalue <= 30) // 4�� ĳ���� ȹ��
            {
                int randomvalue3 = Random.Range(0, 4);
                Debug.Log(CharacterListAAA[randomvalue3] + "�� ȹ���߽��ϴ�.");
            }
            else // 3�� ĳ���� ȹ��
            {
                int randomvalue3 = Random.Range(0, 4);
                Debug.Log(CharacterListBBB[randomvalue3] + "�� ȹ���߽��ϴ�.");
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
