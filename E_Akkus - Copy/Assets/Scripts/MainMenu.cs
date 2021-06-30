using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        // Application.Quit(); Only works in Builded versions.
        Debug.Log("Game Closed");
    }

    public void StartGame ()
    {
        SceneManager.LoadScene("Game");
    }
    ////// Start is called before the first frame update
    ////void Start()
    ////{
        
    ////}

    ////// Update is called once per frame
    ////void Update()
    ////{
        
    ////}
}