using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    // Set this value with your actual high score variable or reference
    public int highScore;

    // This function will be called when the Play button is clicked
    public void PlayGame()
    {
        // Load the game scene
        SceneManager.LoadScene("play");
    }

    // This function will be called when the Quit button is clicked
    public void CloseGame()
    {
        // Load the opening scene
        SceneManager.LoadScene("opening scene");
    }
}
