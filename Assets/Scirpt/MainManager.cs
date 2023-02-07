using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public void LoadPlayScene()
    {
        SceneManager.LoadScene("1.SchoolScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
