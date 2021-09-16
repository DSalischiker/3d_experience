using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsableObjects : MonoBehaviour
{
    public type types;

    public enum type
    {
        WEAPON,
        FLASHLIGHT,
        SHELTER,
        KEY
    }

    public void UseIt()
    {
        print("Me usaron " + gameObject.name);
    }
}
