using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Logic2Script : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverText;
    
    [ContextMenu("Increase Score")]
    
    public void AddScore()
    {
        playerScore ++;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void gameOver()
    {
        gameOverText.SetActive(true);
    }
}
