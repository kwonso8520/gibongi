using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid;
    public float speed = 5;
    private float horizontal;
    private Animator animator;
    private SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        PlayerMove();
        
    }
    private void PlayerMove()
    {
        animator.SetFloat("speed", Mathf.Abs(horizontal));
        if (horizontal < 0)
        {
            renderer.flipX = true;
        }
        else
        {
            renderer.flipX = false;
        }
        rigid.velocity = new Vector2(horizontal * speed, rigid.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Computer"))
        {
            SceneManager.LoadScene("2.GameScene");
        }
    }
}
