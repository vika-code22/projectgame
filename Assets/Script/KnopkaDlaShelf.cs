using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnopkaDlaShelf : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject sledgehammer;
    [SerializeField] private UI ui;
    private bool player = false;
    private bool isTrigger = true;
    private Collider sledgehammerCollider;

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
            animator.SetTrigger("Shelf");
            isTrigger = false;
            ui.OnOffE(false);
        }
    }

    public void HammerCollider()
    {
        sledgehammerCollider.enabled = true;
    }
}
