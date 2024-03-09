using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void switchScenes(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
