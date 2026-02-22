using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private bool isGrounded = false;
    [SerializeField] private float force = 50f;
    [SerializeField] private Rigidbody rb;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            isGrounded = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            }
        }
    }
}
