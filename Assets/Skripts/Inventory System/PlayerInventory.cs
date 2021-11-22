using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private Inventory inventory;
    public bool inRange;
    private ItemCollider itemInRange;
    private ShadowBucket shadowBucket;
    [SerializeField] private UI_Inventory uiInventory;
    [SerializeField] public Animator animator;

    private void Start()
    {
        inRange = false;
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
        shadowBucket = GameObject.Find("Shadow").GetComponent<ShadowBucket>();
        ItemCollider.SpawnItemCollider(new Vector2(0, -10), new Item { itemType = Item.ItemType.Ladle, amount = 1, });
        ItemCollider.SpawnItemCollider(new Vector2(2, -10), new Item { itemType = Item.ItemType.Fork, amount = 1, });
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Return)) && inRange == true)
        {
            animator.SetTrigger("pickup");
            shadowBucket.ShadowAni();
            inventory.AddItem(itemInRange.GetItem());
            Destroy(GameObject.Find(itemInRange.GetItem().itemType.ToString()));
            itemInRange.DestroySelf();
        }

        Debug.Log(inRange);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        ItemCollider itemCollider = collider.GetComponent<ItemCollider>();
        if (collider.gameObject.CompareTag("Item") && itemCollider != null)
        {
            inRange = true;
            itemInRange = itemCollider;
            Debug.Log("ok");
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Item"))
            inRange = false;
        itemInRange = null;

    }
}
