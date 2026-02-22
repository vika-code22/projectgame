using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private bool player = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Нажмите на кнопку Е");
            player = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = false;
        }
    }

    void Update()
    {
        if (player && Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("Open");
        }
    }
}
