using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public Sprite change_img;
    public Sprite change_img2;
    Image thisimg;
    public GameObject text1;
    public GameObject text2;
    public GameObject endcolor;
    public GameObject creditpos;
    void Start()
    {
        thisimg = GetComponent<Image>();
        StartCoroutine("apeargirl");
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    IEnumerator apeargirl()
    {
        yield return new WaitForSeconds(3f);
        text1.SetActive(false);
        endcolor.GetComponent<Image>().color = Color.white;
        thisimg.sprite = change_img;
        text2.SetActive(true);
        yield return new WaitForSeconds(3f);
        text2.SetActive(false);
        endcolor.GetComponent<Image>().color = Color.black;
        yield return new WaitForSeconds(1f);
        for (int i = -600; i < 1700; i++)
        {
            creditpos.GetComponent<RectTransform>().anchoredPosition = new Vector3(-100, i, 0);
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        creditpos.SetActive(false);
        yield return new WaitForSeconds(2f);
        endcolor.GetComponent<Image>().color = Color.white;
        thisimg.sprite = change_img2;
        yield return new WaitForSeconds(0.5f);
        endcolor.GetComponent<Image>().color = Color.black;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("0.MainScene");
    }
}
