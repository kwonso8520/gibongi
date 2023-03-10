using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScenePlayer : MonoBehaviour
{
    public float moveSpeed; // 이동스피드.
    public float jumpPower; // 점프파워.
    public float gravity;   // 중력.

    private CharacterController controller; // 캐릭터 컨트롤러.
    private Vector3 moveDir;                // 방향을 담을 벡터.
    [SerializeField]
    private Vector3 spawnPoint = new Vector3(0, 15, -13);

    void Start()
    {
        moveSpeed = 10.0f;
        gravity = 9.8f;
        jumpPower = 7.0f;

        moveDir = Vector3.zero;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 현재 캐릭터가 땅에 있는가?
        if (controller.isGrounded)
        {
            // 움직임 키보드로부터 입력받기. 
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            // 이동스피드 적용.
            moveDir *= moveSpeed;

            // 점프키(스페이스)를 눌렀다면, 점프파워 적용.
            if (Input.GetButton("Jump"))
                moveDir.y = jumpPower;

        }

        // 중력 적용.
        moveDir.y -= gravity * Time.deltaTime;

        // 캐릭터 움직임.
        controller.Move(moveDir * Time.deltaTime);


        if (transform.position.y < -20)
        {
            // 0, 10, 0 으로 좌표 바꾸기
            transform.position = spawnPoint;
        }
    }
}
