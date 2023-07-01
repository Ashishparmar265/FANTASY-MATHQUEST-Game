using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    public int scoreIncreaseAmount = 10;
    public Text questionText;
    public InputField answerInput;

    private bool isGameStopped = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isGameStopped)
        {
            isGameStopped = true;
            Time.timeScale = 0f; // Pause the game

            // Generate a random math question
            int operand1 = Random.Range(1, 10);
            int operand2 = Random.Range(1, 10);
            int correctAnswer = operand1 + operand2;
            string question = string.Format("What is {0} + {1}?", operand1, operand2);

            // Display the math question
            questionText.text = question;

            // Show the UI elements for the math question
            questionText.gameObject.SetActive(true);
            answerInput.gameObject.SetActive(true);

            // Focus the input field to allow the player to enter their answer
            answerInput.Select();
            answerInput.ActivateInputField();

            // Register a listener for the input field's submit event
            answerInput.onEndEdit.AddListener(OnAnswerSubmitted);
        }
    }

    private void OnAnswerSubmitted(string answer)
    {
        int playerAnswer;

        if (int.TryParse(answer, out playerAnswer))
        {
            // Get the correct answer
            int operand1 = int.Parse(questionText.text.Split(' ')[2]);
            int operand2 = int.Parse(questionText.text.Split(' ')[4]);
            int correctAnswer = operand1 + operand2;

            if (playerAnswer == correctAnswer)
            {
                // Increase the score if the answer is correct
                IncreaseScore();
            }
        }

        // Hide the UI elements for the math question
        questionText.gameObject.SetActive(false);
        answerInput.gameObject.SetActive(false);

        // Unregister the listener for the input field's submit event
        answerInput.onEndEdit.RemoveListener(OnAnswerSubmitted);

        // Resume the game
        Time.timeScale = 1f;
        isGameStopped = false;
    }

    private void IncreaseScore()
    {
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

        if (scoreManager != null)
        {
            scoreManager.IncreaseScore(scoreIncreaseAmount);
        }
        else
        {
            Debug.LogWarning("ScoreManager script not found in the scene.");
        }
    }
}
