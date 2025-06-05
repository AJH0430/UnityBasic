using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class KGA : MonoBehaviour
{

    private string name = "안정환";
    private int age = 29;
    private float height = 178.6f;
    private string place = "서울";
    private string game = "명조";
    private string mbti = "ISTP";
    private string gen = "남자";
    private string hobby = "영화보기 ";


    private void Start()
    {
        SelfIntroduction();
        SelfIntroduction(name, age, height, place, game, mbti, gen, hobby);
    }


    public void SelfIntroduction()
    {
        Debug.Log("저의 이름은" + name + "입니다.");
        Debug.Log($"저의 나이는 {age}살 입니다.");
        Debug.Log("저의 키는" + height + "입니다.");
        Debug.Log($"제가 사는 곳은 {place}입니다.");
        Debug.Log("제가 좋아하는 게임은 " + game + "입니다.");
        Debug.Log($"저의 mbti는 {mbti}입니다.");
        Debug.Log("저의 성별은 " + gen + "입니다.");
        Debug.Log($"저의 취미는 {hobby} 입니다.");
    }

    public void SelfIntroduction(string _name, int _age, float _height, string _place, string _game, string _mbti, string _gen, string _hobby)
    {
        Debug.Log("저의 이름은" + _name + "입니다.");
        Debug.Log($"저의 나이는 {_age}살 입니다.");
        Debug.Log("저의 키는" + _height + "입니다.");
        Debug.Log($"제가 사는 곳은 {_place}입니다.");
        Debug.Log("제가 좋아하는 게임은 " + _game + "입니다.");
        Debug.Log($"저의 mbti는 {_mbti}입니다.");
        Debug.Log("저의 성별은 " + _gen + "입니다.");
        Debug.Log($"저의 취미는 {_hobby} 입니다.");
    }
}
