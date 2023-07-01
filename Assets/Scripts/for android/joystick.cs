using UnityEngine;
using UnityEngine.EventSystems;

public class joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private Vector2 joystickDirection;

    // Called when the joystick is dragged
    public void OnDrag(PointerEventData eventData)
    {
        // Get the direction of the joystick movement
        Vector2 position = transform.position;
        joystickDirection = (eventData.position - position).normalized;
    }

    // Called when the joystick is released
    public void OnPointerUp(PointerEventData eventData)
    {
        joystickDirection = Vector2.zero;
    }

    // Called when the joystick is pressed down
    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    // Get the horizontal value of the joystick
    public float Horizontal
    {
        get { return joystickDirection.x; }
    }

    // Get the vertical value of the joystick
    public float Vertical
    {
        get { return joystickDirection.y; }
    }
}
