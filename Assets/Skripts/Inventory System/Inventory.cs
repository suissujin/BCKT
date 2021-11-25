using System;
using System.Collections.Generic;

public class Inventory
{
    private List<Item> itemList;
    public event EventHandler OnItemListChanged;

    public Inventory()
    {
        itemList = new List<Item>();

        // AddItem(new Item { itemType = Item.ItemType.Fork, amount = 1 });
    }

    public void AddItem(Item item)
    {
        itemList.Add(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<Item> GetItemList() => itemList;
}
