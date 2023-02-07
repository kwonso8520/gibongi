using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float speed = 5;
    private float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        PlayerMove();
        
    }
    private void PlayerMove()
    {
        rigidbody.velocity = new Vector2(horizontal * speed, rigidbody.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Computer"))
        {
            SceneManager.LoadScene("2.GameScene");
        }
    }
}