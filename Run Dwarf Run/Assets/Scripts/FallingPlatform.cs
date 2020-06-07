using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private BoxCollider2D bc2d;
    private float wait = 1f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            Invoke("fall", wait);
        }
    }

    private void fall()
    {
        rb2d.isKinematic = false;
        bc2d.enabled = false;
    }


}
