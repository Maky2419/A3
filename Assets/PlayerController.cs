using UnityEngine;

public class PlayerController : MonoBehaviour
{
     [SerializeField] private Rigidbody sphereRigidbody; 
   public float Speed = 10f;
    public float JumpForce = 5f;
    private int jumpCount = 0;
    private const int maxJumps = 2; // Allows double jump
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
    {
        Vector2 input = Vector2.zero; // Initialize input vector 

        // Movement input
        if (Input.GetKey(KeyCode.W)) input += Vector2.up;
        if (Input.GetKey(KeyCode.S)) input += Vector2.down;
        if (Input.GetKey(KeyCode.D)) input += Vector2.right;
        if (Input.GetKey(KeyCode.A)) input += Vector2.left;

        // Convert input to 3D movement
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * Speed);

        // Jumping and double jump
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJumps)
        {
            sphereRigidbody.linearVelocity = new Vector3(sphereRigidbody.linearVelocity.x, 0, sphereRigidbody.linearVelocity.z); // Reset vertical velocity
            sphereRigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            jumpCount++;
        }
    }

     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) 
        {
            jumpCount = 0;
        }
    }

}
