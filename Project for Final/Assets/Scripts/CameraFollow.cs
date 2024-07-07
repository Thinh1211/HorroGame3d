using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform tragetObject;

    public Vector3 cameraOffset;

    public float smoothFactor = 0.5f;

    public bool lookAtTraget = false;

    void Start()
    {
        cameraOffset = transform.position - tragetObject.transform.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = tragetObject.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);

        if (lookAtTraget)
        {
            transform.LookAt(tragetObject);
        }
    }
}
