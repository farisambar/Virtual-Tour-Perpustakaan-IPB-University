using UnityEngine;
using UnityEngine.InputSystem;

public class DesktopPanoramaLook : MonoBehaviour
{
    [Header("Kecepatan Kontrol")]
    [SerializeField] private float mouseSensitivity = 0.12f;
    [SerializeField] private float keyboardSpeed = 90f;

    [Header("Batas Pandangan Vertikal")]
    [SerializeField] private float minimumPitch = -80f;
    [SerializeField] private float maximumPitch = 80f;

    private float yaw;
    private float pitch;

    private void Start()
    {
        Vector3 currentRotation = transform.localEulerAngles;

        yaw = currentRotation.y;
        pitch = NormalizeAngle(currentRotation.x);
    }

    private void Update()
    {
        ReadMouseInput();
        ReadKeyboardInput();

        pitch = Mathf.Clamp(
            pitch,
            minimumPitch,
            maximumPitch
        );

        transform.localRotation = Quaternion.Euler(
            pitch,
            yaw,
            0f
        );
    }

    private void ReadMouseInput()
    {
        if (Mouse.current == null)
        {
            return;
        }

        // Tahan klik kanan lalu gerakkan mouse.
        if (Mouse.current.rightButton.isPressed)
        {
            Vector2 mouseDelta = Mouse.current.delta.ReadValue();

            yaw += mouseDelta.x * mouseSensitivity;
            pitch -= mouseDelta.y * mouseSensitivity;
        }
    }

    private void ReadKeyboardInput()
    {
        if (Keyboard.current == null)
        {
            return;
        }

        float horizontal = 0f;
        float vertical = 0f;

        // Hanya menggunakan tombol panah.
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal -= 1f;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal += 1f;
        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            vertical += 1f;
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            vertical -= 1f;
        }

        yaw += horizontal * keyboardSpeed * Time.unscaledDeltaTime;
        pitch -= vertical * keyboardSpeed * Time.unscaledDeltaTime;
    }

    private static float NormalizeAngle(float angle)
    {
        while (angle > 180f)
        {
            angle -= 360f;
        }

        while (angle < -180f)
        {
            angle += 360f;
        }

        return angle;
    }
}