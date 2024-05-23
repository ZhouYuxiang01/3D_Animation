using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // The target object to focus on

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogError("Target is not set. Please set the target GameObject in the inspector.");
            return;
        }

        transform.LookAt(target);
    }
}
