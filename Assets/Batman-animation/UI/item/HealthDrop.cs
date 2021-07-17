using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterStats player = collision.GetComponent<CharacterStats>();
        if (collision.gameObject.CompareTag("Player"))
        {
            player.TakePotion();
            Destroy(gameObject);
        }
       

    }

   
}
