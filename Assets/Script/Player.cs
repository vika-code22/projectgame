using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float mouseSensitivity = 2f;
    [SerializeField] private AudioSource audioWalking;

    [SerializeField] private Rigidbody rb;

    private float cameraPitch = 0f;

    private void FixedUpdate()
    {
        HandleMovement();
        HandleCameraRotation();
    }

    private void HandleMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = (transform.forward * moveVertical + transform.right * moveHorizontal).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);

            if (!audioWalking.isPlaying)
                audioWalking.Play();
        }
        else
        {
            audioWalking.Pause();
        }
    }

    private void HandleCameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(Vector3.up, mouseX);

        cameraPitch -= mouseY;
        cameraPitch = Mathf.Clamp(cameraPitch, -90f, 90f);

        cameraTransform.localEulerAngles = new Vector3(cameraPitch, 0f, 0f);
    }
}
