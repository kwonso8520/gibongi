using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private string input;
    [SerializeField]
    private bool isAnswer;

    [SerializeField]
    private GameObject cars;
    [SerializeField]
    private GameObject wall;


    private void OnTriggerEnter(Collider other)
    {
        text.text = "������ " + '\"' + input + '\"' + "\n(��)��� \"F\" Ű�� �����ּ���.";
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (isAnswer == true)
            {
                cars.GetComponent<Animator>().SetTrigger("correct");
                wall.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        text.text = "";
    }
}
