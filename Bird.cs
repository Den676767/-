using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class Bird : MonoBehaviour
{
    public float rotatePower;
    public float jumpSpeed;
    public float speed;

    private Rigidbody2D rb;
    private void Start()
    {
        Pipe.speed = speed;
        rb=GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }
        transform.eulerAngles = new Vector3(0,0,rb.velocity.y * rotatePower);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Game");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SCore.score++;
    }
}
