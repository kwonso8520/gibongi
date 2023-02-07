using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerCheck : MonoBehaviour
{
    private InputField input;
    void Update()
    {
        if (input.text == "GetAxisRaw")
            print("정답입니다!!");
    }
}
