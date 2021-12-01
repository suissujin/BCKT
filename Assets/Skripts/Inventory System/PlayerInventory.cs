using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private Inventory inventory;
    public bool inRange;
    public bool ForkState;
    public bool LadleState;
    private ItemCollider itemInRange;
    private ShadowBucket shadowBucket;
    [SerializeField] private UI_Inventory uiInventory;
    [SerializeField] public Animator animator;

    #region Start 
    private void Start()
    {
        ForkState = false;
        LadleState = false;
        inRange = false;
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
        shadowBucket = GameObject.Find("Shadow").GetComponent<ShadowBucket>();
    }
    #endregion
    #region Update
    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Return)) && inRange == true)
        {
            animator.SetTrigger("pickup");
            shadowBucket.ShadowAni();
            GetComponent<Sound>().Pickup();
            inventory.AddItem(itemInRange.GetItem());
            Destroy(GameObject.Find(itemInRange.GetItem().itemType.ToString()));
            itemInRange.DestroySelf();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && inventory.GetItemList() != null)
        {
            SetStates(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && inventory.GetItemList() != null)
        {
            SetStates(1);
        }
        if (ForkState == true)
        {
            animator.SetTrigger("Fork");
        }
        if (LadleState == true)
        {
            animator.SetTrigger("Ladle");
        }
    }
    #endregion
    #region ItemEquipStates
    public void SetStates(int index)
    {
        switch (inventory.GetItemList()[index].itemType.ToString())
        {
            case "Fork":
                ForkState = true;
                LadleState = false;
                Debug.Log("Fork equipped");

                break;
            case "Ladle":
                ForkState = false;
                LadleState = true;
                Debug.Log("Ladle equipped");
                break;
            // case "Example":
            //     ForkState = false;
            //     LadleState = false;
            //     exampleState = true;
            //break;
            default:
                ForkState = false;
                LadleState = false;
                animator.SetTrigger("Nothing");
                break;
        }
    }
    #endregion
    #region Trigger
    private void OnTriggerEnter2D(Collider2D collider)
    {
        ItemCollider itemCollider = collider.GetComponent<ItemCollider>();
        if (collider.gameObject.CompareTag("Item") && itemCollider != null)
        {
            inRange = true;
            itemInRange = itemCollider;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Item"))
            inRange = false;
        itemInRange = null;
    }

    #endregion
}