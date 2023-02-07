using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //플레이어.
    public GameObject Player;

    //카메라와 플레이어의 거리
    public Vector3 offset;

    //
    void Start()
    {
        //카메라와 플레이어의 거리를 구한다.
        offset = transform.position - Player.transform.position;
    }

    //
    void Update()
    {
        //카메라를 위치를 갱신해준다. = 플레이어 위치 + 오프셋
        transform.position = Player.transform.position + offset;
    }
}