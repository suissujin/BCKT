using UnityEngine;

public class ItemCollider : MonoBehaviour
{
    private Item item;
    private SpriteRenderer spriteRenderer;
    #region SpawnItem
    public static ItemCollider SpawnItemCollider(Vector2 position, Item item)
    {
        // Debug.Log(position);
        // Debug.Log(item);
        Transform transform = Instantiate(ItemAssets.Instance.ItemColliderPF, position, Quaternion.identity);

        ItemCollider itemCollider = transform.GetComponent<ItemCollider>();
        itemCollider.SetItem(item);
        itemCollider.tag = "Item";
        return itemCollider;
    }
    #endregion
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void SetItem(Item item)
    {
        this.item = item;
    }
    public Item GetItem() => item;
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}