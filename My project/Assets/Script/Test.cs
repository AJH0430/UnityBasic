using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class KGA : MonoBehaviour
{

    private string name = "����ȯ";
    private int age = 29;
    private float height = 178.6f;
    private string place = "����";
    private string game = "����";
    private string mbti = "ISTP";
    private string gen = "����";
    private string hobby = "��ȭ���� ";


    private void Start()
    {
        SelfIntroduction();
        SelfIntroduction(name, age, height, place, game, mbti, gen, hobby);
    }


    public void SelfIntroduction()
    {
        Debug.Log("���� �̸���" + name + "�Դϴ�.");
        Debug.Log($"���� ���̴� {age}�� �Դϴ�.");
        Debug.Log("���� Ű��" + height + "�Դϴ�.");
        Debug.Log($"���� ��� ���� {place}�Դϴ�.");
        Debug.Log("���� �����ϴ� ������ " + game + "�Դϴ�.");
        Debug.Log($"���� mbti�� {mbti}�Դϴ�.");
        Debug.Log("���� ������ " + gen + "�Դϴ�.");
        Debug.Log($"���� ��̴� {hobby} �Դϴ�.");
    }

    public void SelfIntroduction(string _name, int _age, float _height, string _place, string _game, string _mbti, string _gen, string _hobby)
    {
        Debug.Log("���� �̸���" + _name + "�Դϴ�.");
        Debug.Log($"���� ���̴� {_age}�� �Դϴ�.");
        Debug.Log("���� Ű��" + _height + "�Դϴ�.");
        Debug.Log($"���� ��� ���� {_place}�Դϴ�.");
        Debug.Log("���� �����ϴ� ������ " + _game + "�Դϴ�.");
        Debug.Log($"���� mbti�� {_mbti}�Դϴ�.");
        Debug.Log("���� ������ " + _gen + "�Դϴ�.");
        Debug.Log($"���� ��̴� {_hobby} �Դϴ�.");
    }
}
