using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cvet : MonoBehaviour
{
    [SerializeField] private Light targetLight;
    [SerializeField] private float minRange = 1f;
    [SerializeField] private float maxRange = 50f;
    [SerializeField] private float speed = 0.5f;

    private void Update()
    {
        if (targetLight == null)
        {
            targetLight = GetComponent<Light>();
        }

        float pingPong = Mathf.PingPong(Time.time * speed, 1);
        targetLight.range = Mathf.Lerp(minRange, maxRange, pingPong);
        
    }
}
