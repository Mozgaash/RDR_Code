using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed;
    public float speed;

    public float jumpPower;
    public bool canJump;
    private bool doubleJump = true;

    private Rigidbody2D rb2d;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey("left"))
        {
            rb2d.AddForce(new Vector2(-3500f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("right"))
        {
            rb2d.AddForce(new Vector2(3500f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);

        }

        if (Input.GetKeyDown("up") && canJump)
        {
            gameObject.GetComponent<Animator>().SetBool("jumping", true);
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0f);
            rb2d.AddForce(new Vector2(0, 1500f));
            
            doubleJump = true;
        }
        else if (Input.GetKeyDown("up") && doubleJump)
        {
            canJump = true;
            gameObject.GetComponent<Animator>().SetBool("jumping", true);
            rb2d.velocity = new Vector2(rb2d.velocity.x / 2, 0f);
            rb2d.AddForce(new Vector2(0, 1200f));
            doubleJump = false;
            canJump = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuScene");
            Debug.Log("salir");
        }

        if (Input.GetKeyDown(KeyCode.M))
            audioSource.mute = !audioSource.mute;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground" || collision.transform.tag == "platform")
        {
            gameObject.GetComponent<Animator>().SetBool("jumping", false);
        }
    }

    private void OnBecameInvisible()
    {
        transform.position = new Vector3(-29, 19, 0);
    }
}
