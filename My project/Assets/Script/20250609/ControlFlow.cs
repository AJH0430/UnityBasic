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


    //private �����Ǿ� �ִ�.
    void Start()
    {
        
    }
    // [��ȭ : �� �ٿ�]
    // ������ �� 1~100 ���̿� ���� ����� 
    // Input Field�� �Էµ� ����
    // ������ ������ ũ�� "ũ��", ������ "�۴�"
    // Count ����
    // ��������� �������


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
                        int randomValue = Random.Range(0, 101); // 1�̻� 100�̸��� ������ ���� �޾� ���ڴ�. (1~100)
                        //���� �Ӹ��� ĳ���Ͱ� ���´�
                        if (randomValue <= 10)
                        {
                            Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");                
                        }
                        else if (randomValue <= 30)
                        {
                            Debug.Log("'��'�� �̾Ҵ�!");                            
                        }
                        else
                        {
                            Debug.Log("'ġġ'�� �̾Ҵ�");                            
                        }
                    }
                }
                break;
            case 1:
                {
                    int randomValue = Random.Range(0, 101); // 1�̻� 100�̸��� ������ ���� �޾� ���ڴ�. (1~100)
                    if (randomValue <= 10)
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾Ҵ�");
                    }
                }
                
                break;
            case 2:
                {
                    int randomValue = Random.Range(0, 101); // 1�̻� 100�̸��� ������ ���� �޾� ���ڴ�. (1~100)
                    if (randomValue <= 10)
                    {
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾Ҵ�");
                    }
                }
                
                break;
            default :
                {
                    int randomValue = Random.Range(0, 101); // 1�̻� 100�̸��� ������ ���� �޾� ���ڴ�. (1~100)
                    if (randomValue <= 10)
                    {
                        Debug.Log("'�ʷ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30)
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾Ҵ�");
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