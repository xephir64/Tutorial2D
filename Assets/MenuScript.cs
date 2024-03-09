using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private int highScore;
    public TextMeshProUGUI highScoreText;
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore");
        highScoreText.SetText("High Score: " + highScore);
    }
    public void switchScenes(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
