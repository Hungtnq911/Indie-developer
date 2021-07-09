using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
{
    
    public void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Player")
        {
            transform.parent = col.transform;
        }
    }
}
