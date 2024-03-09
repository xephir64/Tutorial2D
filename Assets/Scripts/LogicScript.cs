using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSFX;
    private bool isGameOver = false;
    
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if(!isGameOver)
        {
            Debug.Log("Score to add:" + scoreToAdd);
            Debug.Log("PlayerScore before: " + playerScore);
            scoreSFX.Play();
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        isGameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        int highScore = PlayerPrefs.GetInt("highScore");
        if (playerScore > highScore) 
        {
            PlayerPrefs.SetInt("highScore", playerScore);
        }
        isGameOver = true;
        gameOverScreen.SetActive(true);
    }

    public void switchScenes(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
