using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MouseLook : MonoBehaviour
{
    public ButtonManager buttonManager;

    [Range(50, 400)]
    public float mouseSensitivity = 300f;

    public Transform playerBody;

    float xRotation = 0f;

    public TextMeshProUGUI mouseSensitivityText;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {

        if(buttonManager.ShowCanvas)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        mouseSensitivityText.text = mouseSensitivity.ToString();
    }


    public void mouseSensitivitySlider(float newmouseSensitivity)
    {
        mouseSensitivity = newmouseSensitivity;
    }
}
