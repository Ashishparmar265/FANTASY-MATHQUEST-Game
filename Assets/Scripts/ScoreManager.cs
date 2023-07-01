using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Reference to the Text UI component
    private int score = 0;

    private void Start()
    {
        // Initialize the score and update the UI
        score = 0;
        UpdateScoreUI();

        // Start increasing the score over time
        InvokeRepeating("IncreaseScore", 1f, 1f); // Increase score every 1 second
    }

    private void IncreaseScore()
    {
        score++;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text =   score.ToString();
    }
    public void IncreaseScore(int amount)
    {
        score += amount;
        // You can add any additional code here, such as updating UI elements with the new score.
    }
}
