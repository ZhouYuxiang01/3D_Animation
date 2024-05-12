using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1; // Assign the first camera in the Unity Editor
    public Camera camera2; // Assign the second camera in the Unity Editor

    private void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
    }
    void Update()
    {
        // Check if the 'V' key is pressed
        if (Input.GetKeyDown(KeyCode.V))
        {
            camera1.enabled = false;
            camera2.enabled = true;
        }
    }
}
