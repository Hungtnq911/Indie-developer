using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Animator animator;
    public Transform firepoint;
    public GameObject bulletPrefab;
    public float ShootRate = 3f;
    float nextShootingTime = 0f;
    public CharacterStats player;
    void Update()
    {
        
        if (Time.time >= nextShootingTime && player.currentBullet > 0)
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
        animator.SetTrigger("Shooting");
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
