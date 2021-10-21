using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Character character;
    public float jumpSpeed;
    public float ySpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
             character.transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime, Space.World);
        }
    }
}
