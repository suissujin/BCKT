using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;

    private void Awake()
    {
        inventory =  new Inventory();
        uiInventory.SetInventory(inventory);
        ItemCollider.SpawnItemCollider(new Vector2(0, -2), new Item {itemType = Item.ItemType.Fork, amount =1, });
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        ItemCollider itemCollider = collider.GetComponent<ItemCollider>();
        if (itemCollider != null)
        {
            inventory.AddItem(itemCollider.GetItem());
            itemCollider.DestroySelf();
        }
    }
}
