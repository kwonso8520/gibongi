using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= 1.0f)
        {
            // 5.53, 10, 0 으로 좌표 바꾸기
            transform.position
               = new Vector3(5, 5, -1);
           
        }

    }
}
