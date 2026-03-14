using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DlaLittleDuck : MonoBehaviour
{
    [SerializeField] private GameObject littleDuck;
    [SerializeField] private UI ui;
    [SerializeField] private BoxCollider bxLittleDuck;
    [SerializeField] private bool boolLittleDuck;
    [SerializeField] private GameObject nvDuck;
    [SerializeField] private GameObject keyTwo;
    private bool player = false;
    private bool isTrigger = true;

    private void Start()
    {
        if (!bxLittleDuck)
        {
            return;
        }

        bxLittleDuck.enabled = false;
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
            if (!boolLittleDuck && littleDuck.activeSelf)
            {
                isTrigger = false;
                ui.OnOffE(false);
                littleDuck.SetActive(false);
                nvDuck.SetActive(true);
                keyTwo.SetActive(true);
            }

            if (!bxLittleDuck)
            {
                return;
            }

            bxLittleDuck.enabled = true;
        }
    }
}
