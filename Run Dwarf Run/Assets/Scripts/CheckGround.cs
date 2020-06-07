using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{

    private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "platform")
        {
            player.transform.parent = collision.transform;
            player.canJump = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.transform.tag == "ground")
        {
            player.canJump = true;
        }

        if(collision.transform.tag == "platform")
        {
            player.transform.parent = collision.transform;
            player.canJump = true;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.transform.tag == "ground")
        {
            player.canJump = false;
        }

        if (collision.transform.tag == "platform")
        {
            player.transform.parent = null;
            player.canJump = false;
        }
        


    }
}
