using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    public float RotateSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }
        // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float rotX = Input.GetAxis("Mouse X") * RotateSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * RotateSpeed * Mathf.Deg2Rad;

            transform.Rotate(Vector3.up, -rotX);
            transform.Rotate(Vector3.right, rotY);
        }
    }

}
