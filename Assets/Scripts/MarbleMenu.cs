using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MarbleMenu : MonoBehaviour
{
    [SerializeField] GameObject LeftCount;
    [SerializeField] GameObject RightCount;
        
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
                GlobalVariables.LeftCount   = int.Parse(LeftCount.GetComponent<InputField>().text);
                GlobalVariables.RightCount  = int.Parse(RightCount.GetComponent<InputField>().text);

        }
        SceneManager.LoadScene(sceneName);
    }

}
