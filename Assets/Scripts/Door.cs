using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractiveObject
{
    Vector3 originalPos;
    public InteractiveObject needsKey = null;

    void Start() {
        originalPos = gameObject.transform.position;
    }

    public override void OnInteract(Character character)
    {
        soundMachine.makeSound("door");
        base.OnInteract(character);
        print("played audio");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Character>())
        {
            print("en trigger " +  other);
            print("NOMBRE: "+ other.name);
            if (other.gameObject.GetComponent<Character>().inventory.all.Contains(needsKey))
            {
                print("character tiene llave");
                if (transform.position == originalPos) {
                    print("misma position");
                    Open();
                }

            }else {
                print("NO");
                //UI TextBOX with instructions
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Character>().inventory.all.Contains(needsKey)) {
            print("trigger exit");
            Close();
        }


    }
    private void Open(){
        gameObject.transform.position = Vector3.Lerp(originalPos, originalPos + new Vector3(0, 0, 30), 0.5f);
    }
    private void Close(){
        gameObject.transform.position = originalPos;
    }
}
