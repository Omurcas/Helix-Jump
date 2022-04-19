using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    public float turnSpeed;
    private float moveX;
    

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f, moveX * turnSpeed * Time.deltaTime, 0f);
        }
    }
}
