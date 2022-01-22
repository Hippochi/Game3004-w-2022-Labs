using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [Header("Player Camera Properties")]
    public float mouseSensitivity = 10.0f;
    public Transform playerBody;

    private float XRot = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        XRot -= mouseY;
        XRot = Mathf.Clamp(XRot, -90.0f, 90.0f);

        transform.localRotation = Quaternion.Euler(XRot, 0.0f, 0.0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
