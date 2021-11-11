using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item
{
    public enum ItemType
    {
        Fork,
        Ladle, 
        PH1,
        PH2,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Fork:     return ItemAssets.Instance.ForkSprite;
            case ItemType.Ladle:    return ItemAssets.Instance.LadleSprite;
            case ItemType.PH1:      return ItemAssets.Instance.PH1Sprite;
            case ItemType.PH2:      return ItemAssets.Instance.PH2Sprite;
        }
    }  

    public void Awake()
    {
        ItemInteract.SpawnItems(new Vector3(0, -5), new Item { itemType = Item.ItemType.Fork, amount = 1});
    }     
} 




