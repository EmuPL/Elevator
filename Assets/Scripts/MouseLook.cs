using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float MouseSensitivity = 100f;
    [SerializeField] private Transform PlayerBody;
    private float _xRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        _xRotation -= MouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * MouseX);
    }
}