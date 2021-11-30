using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> itemList;
    public UI_Inventory uI_Inventory;
    public event EventHandler OnItemListChanged;
    public Inventory()
    {
        itemList = new List<Item>();
    }

    public void AddItem(Item item)
    {
        itemList.Add(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<Item> GetItemList() => itemList;
    public void RemoveItem()
    {
        itemList.Remove(itemList.Find(item => item.itemType == Item.ItemType.Ladle));
    }
}

