using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.ComponentModel;
using UnityEditor.Tilemaps;

public class Button : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private TextMeshPro problem;
    private string saveProblem;
    
    [SerializeField]
    private bool isAnswer;
    [SerializeField]
    private Button other1; // only for isAnswer == true
    [SerializeField]
    private Button other2; // only for isAnswer == true

    [SerializeField]
    private GameObject cars;
    [SerializeField]
    private GameObject wall;
    [SerializeField]
    private string input;


    private void Start()
    {
        saveProblem = problem.text;
    }

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
                problem.text = "�����Դϴ�!";
                text.text = "";
                cars.GetComponent<Animator>().SetTrigger("correct");
                wall.SetActive(false);

                Destroy(other1.gameObject);
                Destroy(other2.gameObject);
                Destroy(gameObject);
            } 

            else
            {
                problem.text = "Ʋ�Ƚ��ϴ�";
                StopCoroutine("Wait");
                StartCoroutine("Wait");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        text.text = "";
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5f);
        problem.text = saveProblem;
    }
}
