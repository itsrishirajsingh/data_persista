using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update


    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        EditorApplication.ExitPlaymode();

        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
    
