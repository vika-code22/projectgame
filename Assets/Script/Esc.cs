using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esc : MonoBehaviour
{
    [SerializeField] private GameObject esc;
    private bool escape;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !escape)
        {
            esc.SetActive(true);
            Time.timeScale = 0f;
            escape = true;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && escape)
        {
            esc.SetActive(false);
            Time.timeScale = 1f;
            escape = false;
        }
    }
    
}
