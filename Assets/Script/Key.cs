using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private UI ui;
    [SerializeField] private GameObject gmK;
    private bool player = false;
    private bool isTrigger = true;

    void OnTriggerEnter(Collider other)
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
            gmK.SetActive(true);
            ui.OnOffE(false);
            Destroy(gameObject);
            isTrigger = false;
        }

    }

}
