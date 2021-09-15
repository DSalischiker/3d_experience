using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float verticalAxis;
    public float horizontalAxis;

    public Character character;

    // Update is called once per frame
    void Update()
    {
        verticalAxis = Input.GetAxis("Vertical");
        horizontalAxis = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftShift))
            character.Run(true);
        else
            character.Run(false);

        if(Input.GetKeyDown(KeyCode.Space)){
            print("space");
            character.actions.Attack();
            /* character.isAttacking = true; */
        }
    }
}
