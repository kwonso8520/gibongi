using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI text;
    [SerializeField]
    public string answer;

    private void OnTriggerEnter(Collider other)
    {
        text.text = "정답이 " + '\"' + answer + '\"' + "\n(이)라면 \"F\" 키를 눌러주세요.";
    }
    private void OnTriggerExit(Collider other)
    {
        text.text = "";
    }
}
