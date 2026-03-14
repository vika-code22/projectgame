using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private UI ui;
    [SerializeField] private BoxCollider bxScarecrow;
    [SerializeField] private GameObject scarecrow;
    [SerializeField] private bool boolDuck;
    private bool player = false;
    private bool isTrigger = true;

    private void Start()
    {
        if (!bxScarecrow)
        {
            return;
        }

        bxScarecrow.enabled = false;
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
            player = false;
        }
    }

    private void Update()
    {
        if (player && Input.GetKeyDown(KeyCode.E))
        {
            if (boolDuck)
            {
                animator.SetTrigger("Duck");
                isTrigger = false;
                ui.OnOffE(false);
            }

            else if (!boolDuck && scarecrow.activeSelf)
            {
                animator.SetTrigger("Duck");
                isTrigger = false;
                ui.OnOffE(false);
                scarecrow.SetActive(false);
            }

            if (!bxScarecrow)
            {
                return;
            }

            bxScarecrow.enabled = true;

        }
    }
}
