using UnityEngine;
using TMPro; // Import for UI Text

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // UI Text Reference
    private int score = 0; // Score counter

    private void Start()
    {
        UpdateScoreUI(); // Ensure UI is updated on start
    }

    public void IncreaseScore()
    {
        score++; // Increment score
        UpdateScoreUI(); // Update UI text
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score; // Update text
    }
}
