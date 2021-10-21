using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float verticalAxis;
    public float horizontalAxis;
    public int id;
    public Character character;

    // Update is called once per frame
    void Update()
    {
        verticalAxis = Input.GetAxis("Vertical");
        horizontalAxis = Input.GetAxis("Horizontal");

        if(Input.GetMouseButtonDown(0))
            character.OnInteract();

        /* if(Input.GetButtonDown("Jump"))
            print("salto"); */
        /* if (Input.GetKey(KeyCode.LeftShift))
            character.Run(true);
        else
            character.Run(false); */

        /* if(Input.GetMouseButtonDown(1)){
            print("attack");
            character.actions.Attack();

        } */
    }
}
