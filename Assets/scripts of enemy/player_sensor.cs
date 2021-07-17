using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_sensor : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {

            GameObject.Find("Batman").GetComponent<CharacterStats>().TakeDamage(40);
            Debug.Log("Ouch");

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("zone"))
            collision.GetComponent<Enemy_zone>().enabled = true;
       


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("zone"))
            collision.GetComponent<Enemy_zone>().enabled = false;
    }
}
