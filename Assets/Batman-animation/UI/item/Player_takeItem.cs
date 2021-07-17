using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_takeItem : MonoBehaviour
{
        public Animator animator;
    
        private void OnCollisionEnter2D(Collision2D collision)
        {

        if (collision.gameObject.CompareTag("Chest"))
        {
            // take item
            //animator.SetTrigger("dead");
            this.enabled = false;
            GetComponent<Collider2D>().enabled = false;
            StartCoroutine("delay");
            


        }

       
    }
    IEnumerable delay()
    {
        float ai = 3f;
        yield return new WaitForSeconds(ai);

        StopAllCoroutines();
    }

}
