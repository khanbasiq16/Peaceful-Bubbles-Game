using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float levelTime ;    // Total time in seconds
    public TextMeshProUGUI timeText;     // Assign in Inspector
    public int targetScore;        // Score needed to win
    public GameObject winPanel;          // Panel to show when player wins

    public float bubbleSpeed;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel; // assign this in Inspector

    public bool isGameOver = false; // track game state

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        UpdateScore();
    }
    void Update()
{
    if (isGameOver) return;

    // Countdown timer
    if (levelTime > 0)
    {
        levelTime -= Time.deltaTime;
        UpdateTimeUI();
    }
    else
    {
        levelTime = 0;
        CheckGameEnd();
    }
}
void UpdateTimeUI()
{
    if (timeText != null)
        timeText.text = "" + Mathf.CeilToInt(levelTime).ToString();
}


    public void AddScore(int amount)
    {
        if (isGameOver) return; // prevent adding score after game over
        score += amount;
        UpdateScore();
    }

    void UpdateScore()
    {
        if (scoreText != null)
            scoreText.text = "" + score;

        if (score >= targetScore)
        {
            CheckGameEnd();
        }    
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;

        // Stop time
        Time.timeScale = 0f;

        // Show Game Over panel
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        Debug.Log("GAME OVER");
    }
    public void RetryGame()
{
        Debug.Log("Retry button clicked!");
    Time.timeScale = 1f; // reset time in case game was paused
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
void CheckGameEnd()
{
    isGameOver = true;
    Time.timeScale = 0f;

    if (score >= targetScore)
    {
        // Player won
        if (winPanel != null)
            winPanel.SetActive(true);
        Debug.Log("YOU WIN!");
    }
    else
    {
        // Player lost
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
        Debug.Log("GAME OVER");
    }
}

}
