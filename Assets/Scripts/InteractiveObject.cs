using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public Transform Container;
    public AudioSource audioclip;
    public int score;
    public virtual void OnSomethingEnter(GameObject go){
        print("gano " + score + " puntos.");
    }
    public virtual void OnSomethingExit(GameObject go){

    }
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
