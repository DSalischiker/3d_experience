using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : InteractiveObject
{

    public void OnPickup()
    {
        //TODO: Add logic for what happens when key is picked up by character
        print("la agarré");
        gameObject.SetActive(false);
    }

    /* public override void OnSomethingEnter(GameObject go){

        print("soy key: "+ gameObject.name);
        transform.SetParent(go.transform);
        transform.position += new Vector3(0, 2, 0);
    } */
}
