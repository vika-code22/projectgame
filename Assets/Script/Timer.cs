using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float m_Time = 1;
    [SerializeField] private GameObject particle;
    [SerializeField] private ParticleSystem[] particleSystem;
    [SerializeField] private AudioSource audioBabax;
    [SerializeField] private TV tV;
    private bool babax = true;    
    private void Start()
    {

        for (int i = 0; i < particleSystem.Length; i++)
        {
            particleSystem[i].Stop();
        }
        
    }

    private void Update()
    {
        if (!tV.ActiveTv)
            return;

        if (m_Time >= 0)
        {
            m_Time -= Time.deltaTime;
            particle.SetActive(true);

            for (int i = 0; i < particleSystem.Length; i++)
            {
                particleSystem[i].Play();
            }

            if (babax)
            {
                audioBabax.Play();
                for (int i = 0; i < particleSystem.Length; i++)
                {
                    particleSystem[i].Stop();
                }
                babax = false;
            }
        }
        
        if (m_Time < 0)
        {
            particle.SetActive(false);
        }
    }
}
