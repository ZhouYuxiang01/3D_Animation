using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera cameraOne;
    public Camera cameraTwo;

    private bool isCameraOneActive = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Toggle the active state of the cameras
            isCameraOneActive = !isCameraOneActive;

            // Set camera active states based on toggle
            cameraOne.gameObject.SetActive(isCameraOneActive);
            cameraTwo.gameObject.SetActive(!isCameraOneActive);
        }
    }
}