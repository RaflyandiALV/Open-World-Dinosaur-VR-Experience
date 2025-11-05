using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;

public class LockVRCameraPosition : MonoBehaviour
{
    public Vector3 lockedPosition;
    public Vector3 lockedRotation;

    void Start()
    {
        // Set the initial locked position and rotation to the current position and rotation of the camera
        lockedPosition = transform.position;
        lockedRotation = transform.eulerAngles;
    }

    void Update()
    {
        // Continuously set the camera's position and rotation to the locked values
        transform.position = lockedPosition;
        transform.eulerAngles = lockedRotation;

        // Optional: Zero out the XR device's position and rotation if necessary
        InputTracking.Recenter();
    }
}