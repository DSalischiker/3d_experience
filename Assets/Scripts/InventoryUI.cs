using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    //  public List<InteractiveObject> all;
    public InventoryButton button;
    public Transform container;

    public void Add(InteractiveObject io)
    {
        InventoryButton newButton = Instantiate(button, container);
        newButton.Init(io);
    }
    public void Remove(InteractiveObject io)
    {
        InventoryButton mybutton = null;
        InventoryButton[] allInventoryButtons = container.GetComponentsInChildren<InventoryButton>();
        foreach (InventoryButton button in allInventoryButtons)
            if (button.io == io)
                mybutton = button;

        if (mybutton != null)
            Destroy(mybutton.gameObject);
    }
}
