using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractiveObject
{
    Vector3 originalPos;
    public InteractiveObject needsKey = null;
    /* public override void OnSomethingEnter(GameObject go){
        base.OnSomethingEnter(go);
        //SE ABRE
        if(needsKey == null){
            Open();
        }else{
            if(needsKey.name == go.gameObject.GetComponent<Character>().key.name){
                print("la key que necesita es igual a la que tiene");
                Open();
            }else{
                print("esta es la key incorrecta!");
            }
        }
    }
    public override void OnSomethingExit(GameObject go){
        Close();
        //SE CIERRA
    } */
    void Start() {
        originalPos = gameObject.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Character>())
        {
            print("en trigger " +  other);
            if (other.gameObject.GetComponent<Character>().inventory.all.Contains(needsKey))
            {
                transform.position = transform.position + new Vector3(0, 0, 5);
            }else {
                print("NO");
                //UI TextBOX with instructions
            }
        }

        /* InteractiveObject io = other.gameObject.GetComponent<InteractiveObject>();
        if (io != null)  { ioActive = io; } */
    }
    private void OnTriggerExit(Collider other)
    {
        transform.position = originalPos;
    }
    private void Open(){
        gameObject.transform.GetChild(0).position += new Vector3(0, 2, 0);
    }
    private void Close(){
        gameObject.transform.GetChild(0).position -= new Vector3(0, 2, 0);
    }
}
