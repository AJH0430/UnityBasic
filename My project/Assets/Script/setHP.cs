using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class setHP : MonoBehaviour
{
    // �ý��� ��ȹ �����Ѵٰ� �����Ͻð�

    public TextMeshProUGUI Txt_HP;
    public TextMeshProUGUI Txt_Text;

    public Image Img_HPbar;

    public int MaxHP;
    float nowHP;
    // �ּ�ü���� 0

    int Damage;
    int HealPoint;

    void Awake()
    {
        nowHP = MaxHP;
        Initialize();
    }

    public void OnClickDamage() // ������
    {
        Damage = Random.Range(5, 20); // 5 ~ 20 �� ������ �������� ����ǰ� �����

        nowHP -= Damage; // �������� �޴´�.
        if (nowHP < 0) // �׷��� 0���� �������� 0���� �����Ѵ�.
        {
            nowHP = 0;
        }
        Txt_Text.text = $"{Damage}�� �������� �Ծ���.";
        RefreshUI();
    }

    public void OnClickHeal() // ȸ��
    {
        HealPoint = Random.Range(5, 20); // 5 ~ 20 �� ������ �������� ����ǰ� �����
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }
        Txt_Text.text = $"{HealPoint} ��ŭ ȸ���ߴ�.";
        RefreshUI();
    }

    
    void Initialize()
    {
        nowHP = MaxHP;
        RefreshUI();
    }

    void RefreshUI()
    {
        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP} "; // 50 / 100
    }
}
