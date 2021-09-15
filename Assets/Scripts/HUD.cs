using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Inventory inventoryPanel;
    // Start is called before the first frame update
    void Start()
    {
        inventoryPanel.ItemAdded += InventoryScript_ItemAdded;
    }

    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach(Transform slot in inventoryPanel)
        {
            //Border... Image
            Image image = slot.GetChild(0).GetChild(0).GetComponent<Image>();

            //We found the empty slot
            if (!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;

                //TODO: Store a reference to the item

                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
