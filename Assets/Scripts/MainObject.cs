using UnityEngine;
using UnityEngine.SceneManagement;


public class MainObject : MonoBehaviour
{
    public MovementInput movementinput; 
    public float power = 100f; // The power of the main object
    public float speed ; // The speed of the main object

    
    public float powerDecreaseRate = 2f;
    public float speedDecreaseRate = 0.1f;

    private float currentPower;
    private float currentSpeed;

    private void Start()
    {
        // currentPower = power;
        // currentSpeed = speed;
        movementinput.Velocity = speed;
       
    }

    private void Update()
    {

        // Decrease power and speed over time
        power -= powerDecreaseRate * Time.deltaTime;
        speed -= speedDecreaseRate * Time.deltaTime;

        // Apply updated power and speed to MainObject
        UpdateMainObject();

        // Check if power or speed reached zero
        if (currentPower <= 0f || currentSpeed <= 0f)
        {
            // Handle when power or speed reaches zero (e.g., destroy MainObject)
            HandlePowerAndSpeedZero();
        }


    }

    public void DecreasePower(float powerDecreaseRate)
    {
        power -= powerDecreaseRate;
        power = Mathf.Clamp(power, 0f, 100f); // Clamp the power value between 0 and 100
    }

    public void DecreaseSpeed(float speedDecreaseRate)
    {
        speed -= speedDecreaseRate;
        speed = Mathf.Clamp(speed, 0f, float.MaxValue); // Clamp the speed value to non-negative
    }


    private void UpdateMainObject()
    {
        // Update MainObject's power and speed
        // Replace this with the appropriate code for your MainObject implementation
        // For example, if MainObject has a Power and Speed property:
        // MainObject.Power = currentPower;
        // MainObject.Speed = currentSpeed;
    }
    private void HandlePowerAndSpeedZero()
    { 
        

       // SceneManager.LoadScene("opening scene");
    }
    public float GetCurrentPower()
    {
        return power;
    }

}
