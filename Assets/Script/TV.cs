using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV : MonoBehaviour
{
    [SerializeField] private UI ui;
    [SerializeField] private GameObject hammer;
    [SerializeField] private BoxCollider bxHammer;
    [SerializeField] private GameObject Tv;
    [SerializeField] private GameObject slomanTv;
    [SerializeField] private GameObject keyThree;
    [SerializeField] private bool boolTV;
    private bool player = false;
    private bool isTrigger = true;
    private bool activeTv;
    public bool ActiveTv => activeTv;

    private void Start()
    {
        if (!bxHammer)
        {
            return;
        }

        bxHammer.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hammer.activeSelf)
        {
            if (isTrigger && other.CompareTag("Player"))
            {
                ui.OnOffE(true);
                player = true;
            }
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

            if (!boolTV && hammer.activeSelf)
            {
                isTrigger = false;
                ui.OnOffE(false);
                hammer.SetActive(false);
                Tv.SetActive(false);
                slomanTv.SetActive(true);
                keyThree.SetActive(true);
                activeTv = true;
            }

            if (!bxHammer)
            {
                return;
            }

            bxHammer.enabled = true;
        }
    }
}
