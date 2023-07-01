using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseButton : MonoBehaviour
{
    public string openingSceneName = "opening scene";

    // Attach this method to the button's OnClick event
    public void CloseGame()
    {
        // Load the opening scene
        SceneManager.LoadScene(openingSceneName);
    }
}
