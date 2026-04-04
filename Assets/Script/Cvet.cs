using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cvet : MonoBehaviour
{
    [SerializeField] Light targetLight;
    [SerializeField] float minRange = 1f;
    [SerializeField] float maxRange = 50f;
    [SerializeField] float speed = 0.5f;

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
