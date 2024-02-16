using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + cameraOffset;
    }
}
