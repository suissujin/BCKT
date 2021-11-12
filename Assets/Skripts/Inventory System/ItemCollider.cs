using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollider : MonoBehaviour
{
    private Item item;
    private SpriteRenderer spriteRenderer;

    
    public static ItemCollider SpawnItemCollider(Vector2 position, Item item)
    {
        // Debug.Log(position);
        // Debug.Log(item);
        Transform transform = Instantiate(ItemAssets.Instance.ItemColliderPF, position, Quaternion.identity);

        ItemCollider itemCollider = transform.GetComponent<ItemCollider>();
        itemCollider.SetItem(item);

        // Debug.Log(position);
        // Debug.Log(item);
        // Debug.Log(itemCollider);
        // Debug.Log(transform);

        return itemCollider;
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetItem(Item item)
    {
        this.item = item;
    }

    public Item GetItem()
    {
        return item;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
