using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScneMa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PLayGame()
    {
         SceneManager.LoadScene("Ins");
    }

    public void AboutMe()
    {
        SceneManager.LoadScene("About");
    }

    public void ExitGame()
    {
        Application.Quit();

    }

    public void Next()
    {
        SceneManager.LoadScene("Test2");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
