using UnityEngine;

public class RotatingCollectible : MonoBehaviour
{
    public float rotationSpeed = 50f; // Rotation speed

    private void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Find the ScoreManager in the scene and increase score
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        if (scoreManager != null)
        {
            scoreManager.IncreaseScore();
        }

        Destroy(gameObject); // Destroy the collectible
    }
}
