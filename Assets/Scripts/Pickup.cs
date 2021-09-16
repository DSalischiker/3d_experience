using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    Transform originalParent;
    Character character;

    private void Start()
    {
        originalParent = transform.parent;
    }
    public void OnGrab(Character character)
    {
        this.character = character;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Collider>().enabled = false;
        transform.SetParent(character.hand);
        transform.localPosition = Vector3.zero;
        character.inventory.Add( GetComponent<InteractiveObject>() );
        character.ioActive = null;
        this.gameObject.SetActive(false);
    }
    public void Drop()
    {
        this.gameObject.SetActive(true);
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Collider>().enabled = true;
        transform.SetParent(originalParent);
        character.inventory.Remove(GetComponent<InteractiveObject>());
    }
}
