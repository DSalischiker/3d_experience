using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public InputManager inputManager;
    public float moveSpeed, rotateSpeed;
    public int score = 0;
    public GameObject key = null;

    public Inventory inventoryPanel;

    public ActionsManager actions;
    public float speed;
    public float accelerator;

    public bool isAttacking;

    void Update(){
        lookAtMouse();
        /* float rotationValue = inputManager.horizontalAxis; */
        /* if(rotationValue != 0){
            transform.Rotate(Vector3.up * rotationValue * rotationSpeed * Time.deltaTime);
        } */
        Vector3 moveVector = ((Vector3.forward * inputManager.verticalAxis) * moveSpeed * Time.deltaTime);
        if(moveVector != Vector3.zero){
            transform.Translate(moveVector);
        }
        speed = moveVector.z + accelerator;
        actions.SetSpeed(speed);
    }

     public void Run(bool isRunning)
    {
        if (isRunning)
            accelerator = 1;
        else
            accelerator = 0;
    }

    private void lookAtMouse() {
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist;

        if (playerPlane.Raycast(ray, out hitDist)) {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        IInventoryItem item = hit.collider.GetComponent<IInventoryItem>();
        if (item != null)
        {
            inventoryPanel.AddItem(item);
        }
    }

    private void OnCollisionEnter(Collision other) {
        IInventoryItem item = other.collider.GetComponent<IInventoryItem>();
        if (item != null)
        {

            inventoryPanel.AddItem(item);
        }
    }

    private void OnTriggerEnter(Collider other){
        IInventoryItem item = other.gameObject.GetComponent<IInventoryItem>();
        if (item != null)
        {
            print("Collider");
            inventoryPanel.AddItem(item);
        }
        /* InteractiveObject io = other.gameObject.GetComponent<InteractiveObject>();
        if(io != null){
            //Choqué con un InteractiveObject
            io.OnSomethingEnter(gameObject);
            score += io.score;
            if(io.name == "Coin"){

            }else if(io.gameObject.GetComponent<Key>()){
                key = io.gameObject;
            }
        } */
    }
    private void OnTriggerExit(Collider other){
        InteractiveObject io = other.gameObject.GetComponent<InteractiveObject>();
        if(io != null){
            //Choqué con un InteractiveObject
            io.OnSomethingExit(gameObject);
        }
    }
}
