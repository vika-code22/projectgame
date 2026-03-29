using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float m_Time = 1;
    [SerializeField] private GameObject particle;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        if (m_Time >= 0)
        {
            m_Time -= Time.deltaTime;
            particle.SetActive(true);
        }
        
        if (m_Time < 0)
        {
            particle.SetActive(false);
        }
    }
}
