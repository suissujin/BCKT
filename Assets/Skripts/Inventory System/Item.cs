using UnityEngine;

public class Item
{
    public enum ItemType
    {
        Fork,
        Ladle,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            case ItemType.Fork:
                return ItemAssets.Instance.ForkSprite;
            case ItemType.Ladle:
                return ItemAssets.Instance.LadleSprite;
            default:
                return null;
        }
    }
}