using UnityEngine;

public class RotatingCollectible : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation
    public static int score = 0; // Global score

    void Update()
    {
        // Rotate the cube over time (like Earth's rotation)
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
            score++; // Increase score
            Debug.Log("Score: " + score);
            Destroy(gameObject); // Remove the cube
    }
}
