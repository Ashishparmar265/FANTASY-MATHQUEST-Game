using UnityEngine;
using UnityEngine.UI;

public class powerslider : MonoBehaviour
{
    public MainObject powerScript;
    public Slider powerSlider;

    private void Update()
    {
        // Access the power value from the power script
        float powerValue = powerScript.GetCurrentPower();

        // Update the slider value
        powerSlider.value = powerValue;
    }
}
