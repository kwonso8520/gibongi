using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private GameObject fkey;

    [SerializeField]
    private int sceneNum;

    private void Start()
    {
        fkey = transform.Find("fkey").gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        fkey.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
            SceneManager.LoadScene(sceneNum);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
            SceneManager.LoadScene(sceneNum);
    }

    private void OnTriggerExit(Collider other)
    {
        fkey.SetActive(false);
    }
}
