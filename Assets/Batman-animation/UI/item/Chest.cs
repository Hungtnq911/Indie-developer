using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject impactEffect;
    public GameObject health_item;
    public GameObject bullet_item;
    public Transform chest_positon;

    void OnTriggerEnter2D(Collider2D collision)
    {
       // CharacterStats player = collision.GetComponent<CharacterStats>();

        if (collision.gameObject.CompareTag("Player"))
        {
            int bullet = Random.Range(0, 4);
            int health = Random.Range(0, 4);
            for(int i = 0;i < bullet; i++)
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
