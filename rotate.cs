using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public float sensitivity = 100f;
    public Transform body;
    float Xrot = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity  * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity  * Time.deltaTime;

        Xrot -= mouseY;

        Xrot = Mathf.Clamp(Xrot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(Xrot, 0f, 0f);

        body.Rotate(Vector3.up * mouseX * sensitivity * Time.deltaTime );

    }
}
