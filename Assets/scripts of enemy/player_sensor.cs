using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_sensor : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask layer;
    public int k = 0;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
            collision.GetComponent<Enemy_zone>().enabled = true;
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.GetComponent<Enemy_zone>().enabled = false;
    }
}
