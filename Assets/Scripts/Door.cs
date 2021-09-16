using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractiveObject
{
    /* public GameObject needsKey = null;
    public override void OnSomethingEnter(GameObject go){
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
    }

    private void Open(){
        gameObject.transform.GetChild(0).position += new Vector3(0, 2, 0);
    }
    private void Close(){
        gameObject.transform.GetChild(0).position -= new Vector3(0, 2, 0);
    } */
}
