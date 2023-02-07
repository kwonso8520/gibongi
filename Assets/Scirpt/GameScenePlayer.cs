using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScenePlayer : MonoBehaviour
{
    public float moveSpeed; // �̵����ǵ�.
    public float jumpPower; // �����Ŀ�.
    public float gravity;   // �߷�.

    private CharacterController controller; // ĳ���� ��Ʈ�ѷ�.
    private Vector3 moveDir;                // ������ ���� ����.

    private GameObject fkey;

    void Start()
    {
        moveSpeed = 5.0f;
        jumpPower = 7.0f;
        gravity = 9.8f;

        moveDir = Vector3.zero;
        controller = GetComponent<CharacterController>();

        fkey = GameObject.Find("fkey");
    }

    void Update()
    {
        // ���� ĳ���Ͱ� ���� �ִ°�?
        if (controller.isGrounded)
        {
            // ������ Ű����κ��� �Է¹ޱ�. 
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            // �̵����ǵ� ����.
            moveDir *= moveSpeed;

            // ����Ű(�����̽�)�� �����ٸ�, �����Ŀ� ����.
            if (Input.GetButton("Jump"))
                moveDir.y = jumpPower;

        }

        // �߷� ����.
        moveDir.y -= gravity * Time.deltaTime;

        // ĳ���� ������.
        controller.Move(moveDir * Time.deltaTime);


        if (transform.position.y < -20)
        {
            // 0, 10, 0 ���� ��ǥ �ٲٱ�
            transform.position
               = new Vector3(0, 15, -13);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "portal")
            fkey.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "portal")
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "portal")
            fkey.SetActive(false);
    }
}
