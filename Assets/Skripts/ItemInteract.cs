using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteract : MonoBehaviour
{
    public static ItemInteract SpawnItems(Vector3 position, Item item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.ItemPF, position, Quaternion.identity);

        ItemInteract itemInteract = transform.GetComponent<ItemInteract>();
        itemInteract.SetItem(item);

        return itemInteract;
    }

    private void Awake()
    {
        ItemInteract.SpawnItems(new Vector2(0, -5), new Item { itemType = Item.ItemType.Fork, amount =1 });
        ItemInteract.SpawnItems(new Vector2(2, -5), new Item { itemType = Item.ItemType.Ladle, amount =1 });
    }


    private Item item;
    private SpriteRenderer spriteRenderer;

    public void SetItem(Item item)
    {
        this.item =item;
        spriteRenderer.sprite = item.GetSprite();
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
