using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playercontroler : MonoBehaviour
{
    public Joystick joystick1; // Reference to the joystick for movement
    public Joystick joystick2; // Reference to the joystick for looking around
    public float movementSpeed = 5f; // Speed of player movement

    void Update()
    {
        // Get input from joystick 1 for movement
        float moveHorizontal = joystick1.Horizontal;
        float moveVertical = joystick1.Vertical;

        // Move the player
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        transform.Translate(movement * movementSpeed * Time.deltaTime);

        // Get input from joystick 2 for looking around
        float lookHorizontal = joystick2.Horizontal;
        float lookVertical = joystick2.Vertical;

        // Rotate the player's view
        transform.Rotate(new Vector3(0f, lookHorizontal, 0f));

        // Rotate the camera
        Camera.main.transform.Rotate(new Vector3(-lookVertical, 0f, 0f));
    }
}
