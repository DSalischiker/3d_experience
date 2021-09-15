using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    /* public List<InteractiveObject> all; */
    private const int slots = 9;

    public List<IInventoryItem> mItems = new List<IInventoryItem>();

    public event EventHandler<InventoryEventArgs> ItemAdded;

    public void AddItem(IInventoryItem item)
    {
        if(mItems.Count < slots)
        {
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            if (collider.enabled)
            {
                collider.enabled = false;
                mItems.Add(item);
                item.OnPickup();

                if (ItemAdded != null)
                {
                    ItemAdded(this, new InventoryEventArgs(item));
                }
            }
        }
    }
    /* public void Add(InteractiveObject io)
    {
        if (all.Count >= inventoryLimit)
        {
            return;
        } else
        {
            all.Add(io);
        }

    }

    public void Remove(InteractiveObject io)
    {
        all.Remove(io);
    } */
}
