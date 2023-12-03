using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LidDar : MonoBehaviour
{
    public GameObject laserPrefab;
    public TMP_Text lidarText;
    float distanceCoef=2.1f;
    float laserTimer;
    float laserCooldown=0.40f;
    
   
    void Start()
    {
        laserTimer=laserCooldown;
    }


    void FixedUpdate()
    {
        laserTimer -= Time.deltaTime;
        if (laserTimer <= 0)
        {
            ShootLaser();
            laserTimer=laserCooldown;
        }
    }

    void ShootLaser()
    {
        GameObject laserShot = Instantiate(laserPrefab, transform.position, transform.rotation);//GameObject laserShot = Instantiate(laserPrefab, transform.position, transform.rotation);
        laserShot.GetComponent<LidarLaser>().sensor=gameObject;
        laserShot.GetComponent<Rigidbody>().velocity = new Vector3(0, -2, 0);
        
    }

    public void RecieveLaser(float time)
    {
        //Debug.Log("Time: " + time + " Distance: "+Mathf.Round(2*time*distanceCoef*100f)/100f+"m");
        //lidarText.text="Lidar(m): " + (Mathf.Round(2*time*distanceCoef*100f)/100f).ToString();
        lidarText.text =  (Mathf.Round(2 * time * distanceCoef * 100f) / 100f).ToString();
    }
}
