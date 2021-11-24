using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public int score;
    public string objectName;
    public Sprite thumb;
    public SoundGenerator soundMachine;
    public int power;
    [HideInInspector] public Character character;

    public virtual void OnInteract(Character character)
    {
        this.character = character;
        Pickup pickup = GetComponent<Pickup>();

        if (pickup != null)
        {
            pickup.OnGrab(character);
        }

    }
    public virtual void UseIt()
    {
        Pickup pickup = GetComponent<Pickup>();
        if (pickup != null)
        {
            pickup.Drop();
        }
    }
    public virtual void openIt() {

    }
}
