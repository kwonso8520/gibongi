using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public Sprite change_img;
    Image thisimg;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject endcolor;
    public GameObject txtobj;
    public GameObject creditpos;
    // Start is called before the first frame update
    void Start()
    {
        thisimg = GetComponent<Image>();
        StartCoroutine("apeargirl");
        for(int i = -600;i < 1400; i++)
        {
            creditpos.transform.position = new Vector3(-100, i, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    IEnumerator apeargirl()
    {
        yield return new WaitForSeconds(1f);
        text1.SetActive(false);
        endcolor.GetComponent<Image>().color = Color.white;
        thisimg.sprite = change_img;
        text2.SetActive(true);
        yield return new WaitForSeconds(2f);
        text2.SetActive(false);
        endcolor.GetComponent<Image>().color = Color.black;
        yield return new WaitForSeconds(1f);
    }
}
