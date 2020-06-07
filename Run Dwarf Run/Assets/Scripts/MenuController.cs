using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectMap1()
    {
        SceneManager.LoadScene("scene1");
    }
    public void SelectMap2()
    {
        SceneManager.LoadScene("scene2");
    }
    public void SelectMap3()
    {
        SceneManager.LoadScene("scene3");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("salir");
    }

}
