using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ball;
    private Vector3 offset;
    public float camSpeed;

    private void Start()
    {
        offset = transform.position - ball.position;
    }

    private void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + ball.position, camSpeed);
        transform.position = newPos;
    }
}
