using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private UI ui;
    [SerializeField] private BoxCollider bxKey;
    [SerializeField] private GameObject key;
    [SerializeField] private AudioSource audioOpen;
    [SerializeField] private bool boolOpen;
    private bool player = false;
    private bool isTrigger = true;

    private void Start()
    {
        if (!bxKey)
        {
            return;
        }

        bxKey.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isTrigger && other.CompareTag("Player"))
        {
            ui.OnOffE(true);
            player = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ui.OnOffE(false);
            player = false;
        }
    }

    private void Update()
    {
        if (player && Input.GetKeyDown(KeyCode.E))
        {
            if (boolOpen)
            {
                animator.SetTrigger("Open");
                audioOpen.Play();
                isTrigger = false;
                ui.OnOffE(false);
            }
            else if (!boolOpen && key.activeSelf)
            {
                animator.SetTrigger("Open");
                audioOpen.Play();
                isTrigger = false;
                ui.OnOffE(false);
                key.SetActive(false);
            }

            //if (bxKey)
            //{
            //    bxKey.enabled = true;
            //}

            if (!bxKey)
            {
                return;
            }

            bxKey.enabled = true;

        }
    }
}
