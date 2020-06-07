using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestController : MonoBehaviour
{

    private SpriteRenderer sr;
    private Sprite closedChest, openedChest;

    private float wait = 2f;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        closedChest = Resources.Load<Sprite>("Sprites/misc/cofreCerrado");
        openedChest = Resources.Load<Sprite>("Sprites/misc/cofreAbierto");

        // aseguro que sea el sprite del cofre cerrado
        sr.sprite = closedChest;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("entro en colisión");
            sr.sprite = openedChest;

            Invoke("changeScene", wait);
        }
        
    }

    private void changeScene()
    {
        Debug.Log("entro en el cambio de escena");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        if (SceneManager.GetActiveScene().buildIndex + 1 == 4)
        {
            SceneManager.LoadScene("MenuScene");
        }
    }

    

}
