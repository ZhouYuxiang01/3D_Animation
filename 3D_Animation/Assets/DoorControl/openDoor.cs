using UnityEngine;

public class openDoor : MonoBehaviour
{
    private Animator doorAnimator;

    private void Start()
    {
        doorAnimator = this.transform.parent.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetTrigger("openDoor");
    }
}
