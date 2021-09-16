using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : InteractiveObject
{
    public UsableObjects asset_in_hand;

    public override void UseIt()
    {
        character.actions.GetObject(asset_in_hand);
        print("UseIt: soy una espada, no me dejo"); // que hago ?
    }
}
