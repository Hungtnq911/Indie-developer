using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_zone : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 raycastDirection = Vector3.up;
        float mRaycastingDistance = 1f;
        RaycastHit2D hit = Physics2D.Raycast(transform.position + raycastDirection * mRaycastingDistance - new Vector3(0f, 0.25f, 0f), raycastDirection, 0.075f);
        if (hit.collider!= null)
        {
            if (hit.transform.tag == "Player")
            {
                hey = true;
            }
            else
                hey = false;
        }
        u = hey;
    }
    private bool hey=false;

    public bool u = true;

    public bool Grabb()
    {
        
            return true;
    }

}
