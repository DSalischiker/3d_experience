using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeZone : MonoBehaviour
{
    NPC npc;
    // Start is called before the first frame update
    void Start()
    {
        npc = GetComponentInParent<NPC>();
    }

    private void OnTriggerEnter(Collider other) {
        Character character = other.gameObject.GetComponent<Character>();
        if (character != null)
        {
            npc.OnCharacterEnterViewZone(character);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.GetComponent<Character>())
        {
            npc.OnCharacterEnterViewZone(null);
        }
    }
}
