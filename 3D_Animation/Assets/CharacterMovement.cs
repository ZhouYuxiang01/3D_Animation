using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5f; // Speed of the character movement
    public float rotationSpeed = 100f; // Speed of character rotation

    private Animator animator; // Reference to the Animator component

    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component attached to the character
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the player
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Move the character forward or backward based on input
        if (verticalInput > 0.1f)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (verticalInput < -0.1f)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        // Rotate the character left or right based on input
        if (horizontalInput > 0.1f)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else if (horizontalInput < -0.1f)
        {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }

        // Set isWalking parameter in the Animator
        if (Mathf.Abs(verticalInput) > 0.1f || Mathf.Abs(horizontalInput) > 0.1f)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
