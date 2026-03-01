using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject gmE;

    private void Start()
    {
            
    }

    private void Update()
    {
        
    }

    public void OnOffE(bool active)
    {
        gmE.SetActive(active);
    }
}
