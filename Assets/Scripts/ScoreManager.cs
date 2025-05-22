    using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public LevelManager levelManager;
    public int score = 0;
    public Text scoreText;  // Assign in Inspector

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (score == 10)
        {
            levelManager.LoadNextLevel();
        }
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}
