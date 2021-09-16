using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public Transform Container;
    public AudioSource audioclip;
    public int score;

    public string objectName;
    public Sprite thumb;
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
    /* public virtual void OnSomethingEnter(GameObject go){
        print("gano " + score + " puntos.");
    }
    public virtual void OnSomethingExit(GameObject go){

    } */
    /* public virtual void OnSomethingEnter(GameObject go){
            print(go.name + " enter.");
    }
    public virtual void OnSomethingExit(GameObject go){
            print(go.name + " exit.");
    }

    private void OnTriggerEnter(Collider other) {
        OnSomethingEnter(other.gameObject);
    }
    private void OnTriggerExit(Collider other) {
        OnSomethingExit(other.gameObject);
    } */
}
