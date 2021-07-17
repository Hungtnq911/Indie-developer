using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 100;
    public GameObject deathEffect;
    public string type = "man";

    public Rigidbody2D rb;
    public GameObject impactEffect;
    public GameObject health_item;
    public GameObject bullet_item;
    public Transform chest_positon;

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        if (type == "man")
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
        else 
            if (type=="chest")
        {

            int bullet = Random.Range(0, 4);
            int health = Random.Range(0, 4);
            for (int i = 0; i < bullet; i++)
            {
                Instantiate(bullet_item, chest_positon.position, chest_positon.rotation);
            }
            for (int i = 0; i < health; i++)
            {
                Instantiate(health_item, chest_positon.position, chest_positon.rotation);
            }

            Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }
}
