using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public float ShootRate = 3f;
    float nextShootingTime = 0f;
    void Update()
    {
        if (Time.time >= nextShootingTime)
        {
            if(Input.GetKeyDown(KeyCode.X))
            {
            Shoot();
            nextShootingTime = Time.time + 1f / ShootRate;
            }
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
