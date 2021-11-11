using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadowBucket : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator animator;
    //public Transform target;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector2(target.transform.position.x, target.transform.position.y);
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical"); 

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        
        if(movement.x !=0)
        {
            movement.y = 0;
        }

        //if(Input.GetAxisRaw("Horizontal")==1 || Input.GetAxisRaw("Horizontal")==-1 || Input.GetAxisRaw("Vertical")==1 || Input.GetAxisRaw("Vertical")==-1)
        if( movement.x != 0 || movement.y != 0 )
        {
           animator.SetFloat("LastHorizontal", Input.GetAxisRaw("Horizontal"));
           animator.SetFloat("LastVertical", Input.GetAxisRaw("Vertical"));
        }
    }
}
