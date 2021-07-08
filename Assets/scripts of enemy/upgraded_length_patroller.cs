using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgraded_length_patroller : MonoBehaviour
{
    public float mMovementSpeed = 1.5f;
    public bool bIsGoingRight = true;
    public float mRaycastingDistance = 1f;
    private SpriteRenderer _mSpriteRenderer;
    public float length_timer = 6;
    // Start is called before the first frame update
    public string id = "ABC";
    private enum State
    {
        patrol, 
        shooting,
    }
    private State state;
    private void Awake()
    {
        state = State.patrol;
    }
    void Start()
    {
        _mSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _mSpriteRenderer.flipX = !bIsGoingRight;



    }


    void Update()
    {
        bool flipstate=false;

        Vector3 directionTranslation = (bIsGoingRight) ? transform.right : -transform.right;

        Vector3 raycastDirection = (bIsGoingRight) ? Vector3.right : Vector3.left;

        
        RaycastHit2D hit = Physics2D.Raycast(transform.position + raycastDirection * mRaycastingDistance - new Vector3(0f, 0.25f, 0f), raycastDirection, 0.075f);
        switch (state)
        { 
            default:
            case State.patrol:
                {
                    // if the ennemy is going right, get the vector pointing to its right



                    directionTranslation *= Time.deltaTime * mMovementSpeed;
                    transform.Translate(directionTranslation);

            if (hit.collider != null)
            {
                if (hit.transform.tag == "Terrain")
                {
                    bIsGoingRight = !bIsGoingRight;
                    _mSpriteRenderer.flipX = !bIsGoingRight;

                }
            }
            if (length_timer >0)
            StartCoroutine("delay");
            
        }; break;

            case State.shooting:
                {
                    directionTranslation *= Time.deltaTime * 0;
                    transform.Translate(directionTranslation);

                };break;

        }

        

        if ( flipstate)
        {
            state = State.shooting;
        }
        else
        {
            state = State.patrol;
        }

        Enemy_zone k= GameObject.Find(id).GetComponent<Enemy_zone>();
        flipstate = k.GetComponent<Enemy_zone>().Grabb();
            
        // for (int i=0;i<5;i++)





    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(length_timer);
        transform.Translate(Vector3.zero);
        bIsGoingRight = !bIsGoingRight;
        _mSpriteRenderer.flipX = !bIsGoingRight;
        StopCoroutine("delay");
        //StopAllCoroutines();
    }

   

}