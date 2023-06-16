using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarbleMenu : MonoBehaviour
{
    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }

    public void LoadNextScene(string sceneName)
    {
        
        if (SceneManager.GetActiveScene().name == "Start")
        {
            //int number = int.Parse(input.text);
            GlobalVariables.LefttCount = 1;
            GlobalVariables.RightCount = 2;
        }
        SceneManager.LoadScene(sceneName);
    }

}
