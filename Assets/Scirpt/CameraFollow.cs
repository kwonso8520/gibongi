using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //�÷��̾�.
    public GameObject Player;

    //ī�޶�� �÷��̾��� �Ÿ�
    public Vector3 offset;

    //
    void Start()
    {
        //ī�޶�� �÷��̾��� �Ÿ��� ���Ѵ�.
        offset = transform.position - Player.transform.position;
    }

    //
    void Update()
    {
        //ī�޶� ��ġ�� �������ش�. = �÷��̾� ��ġ + ������
        transform.position = Player.transform.position + offset;
    }
}