using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_sensor : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask layer;
    public int k = 0;
    // Update is called once per frame
    void Update()
    {
        Vector3 raycastDirection = Vector3.down;
        float mRaycastingDistance = 1f;
        RaycastHit2D hit = Physics2D.Raycast(transform.position + raycastDirection * mRaycastingDistance - new Vector3(0f, 0.25f, 0f), raycastDirection, 0.075f);

        if (hit.collider != null)
        {
            if (hit.transform.tag == "zone")
            {
                Collider2D[] zonetouch = Physics2D.OverlapCircleAll(transform.position,0.2f,layer);
                foreach (Collider2D enemyzone in zonetouch)
                {
                    enemyzone.GetComponent<Enemy_zone>().u = false;
                    Debug.Log("IN the zone now");
                    k++;
                }
            }
            
        }
    }
}
