using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    public float speed = 5.0f; // Speed of the character movement
    public float rotationSpeed = 720.0f; // Speed of character rotation

    private Animator animator; // Reference to the Animator component
    private CharacterController characterController; // Reference to the CharacterController component

    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component attached to the character
        animator = GetComponent<Animator>();

        // Get the CharacterController component attached to the character
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the player
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate movement direction based on input
        Vector3 moveDirection = new Vector3(0, 0, verticalInput);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        // Move the character using CharacterController
        characterController.Move(moveDirection * Time.deltaTime);

        // Rotate the character based on input
        if (horizontalInput != 0)
        {
            transform.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
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

        // Trigger push animation
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("push");
        }
    }
}
