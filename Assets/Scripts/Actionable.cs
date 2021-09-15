using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actionable : MonoBehaviour
{
    public string id;
    public KeyCode key;
    public bool isTriggered;
    public GameObject actionableObject;

    private void OnTriggerEnter(Collider other) {
        isTriggered = true;
        actionableObject.transform.position += new Vector3(0, 2, 0);
    }
    private void OnTriggerExit(Collider other) {
        isTriggered = false;
        actionableObject.transform.position -= new Vector3(0, 2, 0);
    }
}



