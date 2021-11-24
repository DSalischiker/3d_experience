using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;
    public float speed = 0.7f;
    private Vector3 targetPosition;

    NPC npc;
    // Update is called once per frame

    void Start() {
        npc = GetComponent<NPC>();
        targetPosition = transform.position + (transform.forward * 10);
    }

    public void LookAt(Character character) {
        if (character == null)
        {
            target = null;
            return;
        }
        target = character.transform;
    }

    void Update()
    {
        if(target == null) {
            return;
        }else{
            Vector3 direction = target.position;
            direction.y = transform.position.y;
            targetPosition = Vector3.Lerp(targetPosition, direction, speed * Time.deltaTime);
            transform.LookAt(targetPosition);
        }
    }

   /*  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Character>())
        {
            target = other.transform;
        }
    } */
}
