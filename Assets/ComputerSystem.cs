using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("video_delay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator video_delay()
    {
        yield return new WaitForSeconds(2.7f);
        SceneManager.LoadScene("1.SchoolScene");
    }
}
