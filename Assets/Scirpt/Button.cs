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
        text.text = "������ " + '\"' + answer + '\"' + "\n(��)��� \"F\" Ű�� �����ּ���.";
    }
    private void OnTriggerExit(Collider other)
    {
        text.text = "";
    }
}
