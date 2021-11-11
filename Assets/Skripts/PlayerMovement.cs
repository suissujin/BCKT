using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    private Inventory inventory;

    [SerializeField] private UI_Inventory uiInventory;

    Vector2 movement;

    private void Awake()
{
    inventory = new Inventory();
    uiInventory.SetInventory(inventory);
}

    // Update is called once per frame
    void Update()
    {
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

    private void OnTriggerEnter2D(Collider2D collider)
    {
        ItemInteract itemInteract = collider.GetComponent<ItemInteract>();
        if (itemInteract != null)
        {
            //add trigger with button instead of touching
            inventory.AddItem(itemInteract.GetItem());
            itemInteract.DestroySelf();
        }
    }
    
    //not dependend on frame update to process
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
