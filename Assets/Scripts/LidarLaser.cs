using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidarLaser : MonoBehaviour
{
    public GameObject sensor;
    float timer;

    void FixedUpdate()
    {
        timer+=Time.deltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        sensor.GetComponent<LidDar>().RecieveLaser(timer);
        Destroy(gameObject);
    }
}
