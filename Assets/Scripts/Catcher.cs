using UnityEngine;

public class Catcher : MonoBehaviour
{
    public float speed = 5f; // The speed at which the chaser moves
    public float powerDecreaseAmount = 10f; // The amount of power decrease when watched by the main object

    [SerializeField] private GameObject mainObject; // Reference to the main object

    private void Start()
    {
        mainObject = GameObject.FindGameObjectWithTag("Jammo_Player"); // Find the main object by tag
    }

    private void Update()
    {
        // Calculate the direction from the chaser to the main object
        Vector3 direction = mainObject.transform.position - transform.position;
        direction.Normalize(); // Normalize the direction vector

        // Move the chaser towards the main object
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jammo_Player"))
        {
            // Decrease the power and speed of the main object when caught
            MainObject mainObjectScript = other.GetComponent<MainObject>();
            mainObjectScript.DecreasePower(powerDecreaseAmount);
            mainObjectScript.DecreaseSpeed(speed);
        }
    }
}
