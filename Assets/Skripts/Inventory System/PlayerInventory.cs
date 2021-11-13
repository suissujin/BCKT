using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private Inventory inventory;
    public bool inRange;
    private ItemCollider itemInRange;
    [SerializeField] private UI_Inventory uiInventory;
    [SerializeField] public Animator animator;

    private void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
        ItemCollider.SpawnItemCollider(new Vector2(0, -10), new Item { itemType = Item.ItemType.Ladle, amount = 1, });
        ItemCollider.SpawnItemCollider(new Vector2(2, -10), new Item { itemType = Item.ItemType.Fork, amount = 1, });
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && inRange)
        {
            animator.SetTrigger("pickup");
            inventory.AddItem(itemInRange.GetItem());
            Destroy(GameObject.Find(itemInRange.GetItem().itemType.ToString()));
            itemInRange.DestroySelf();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        ItemCollider itemCollider = collider.GetComponent<ItemCollider>();
        if (itemCollider != null)
        {
            inRange = true;
            itemInRange = itemCollider;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        inRange = false;
        itemInRange = null;

    }
}
