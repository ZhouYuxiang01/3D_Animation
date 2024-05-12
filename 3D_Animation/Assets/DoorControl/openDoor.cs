using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator doorAnimator;
    public AudioClip openSound; // Sound clip to play when the door opens

    private void Start()
    {
        doorAnimator = transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetTrigger("openDoor");

        // Play the open sound if available
        PlayOpenSound();
    }

    private void PlayOpenSound()
    {
        if (openSound != null)
        {
            AudioSource.PlayClipAtPoint(openSound, transform.position);
        }
    }
}
