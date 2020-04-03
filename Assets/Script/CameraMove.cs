using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform BallTransform;
    private Vector3 CameraOffset;

    [Range(0.1f,1.0f)]
    public float Smooth = 0.5f;
    public bool LookAtPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        CameraOffset = transform.position - BallTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = BallTransform.position + CameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPosition, Smooth);

        if (LookAtPlayer)
            transform.LookAt(BallTransform);
    }
}
