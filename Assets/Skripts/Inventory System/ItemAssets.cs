using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance
    {
        get;
        private set;
    }

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        ItemCollider.SpawnItemCollider(new Vector2(0, -10), new Item { itemType = Item.ItemType.Ladle, amount = 1, });
        ItemCollider.SpawnItemCollider(new Vector2(17, -1), new Item { itemType = Item.ItemType.Fork, amount = 1, });
    }

    public Transform ItemColliderPF;
    public Sprite ForkSprite;
    public Sprite LadleSprite;
}
