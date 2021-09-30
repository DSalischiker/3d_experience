using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    public float speed = 0.7f;
    private Vector3 targetPosition;
    // Update is called once per frame

    void Start() {
        targetPosition = transform.position + (transform.forward * 10);
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
            print(targetPosition);
            /* Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime); */
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Character>())
        {
            target = other.transform;
        }
    }
}
