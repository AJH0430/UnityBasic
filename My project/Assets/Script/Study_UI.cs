using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Study_UI : MonoBehaviour
{
    public TextMeshProUGUI txt_Text;
    public string nextText = "�׳׳׳׳׳׳׳�";

    public void OnClickButton()
    {
        txt_Text.text = nextText;
    }
}
