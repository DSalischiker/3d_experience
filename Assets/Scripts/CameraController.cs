using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Character character;
    private Vector3 offset;
    public float smooth;
    // Start is called before the first frame update
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - character.transform.position;
    }

   // LateUpdate is called after Update each frame
    void LateUpdate ()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = character.transform.position + offset;
    }



    /* void Update()
    {
        offset = transform.position - character.transform.position;
        transform.position = Vector3.Lerp(transform.position, offset, smooth * Time.deltaTime);
    } */
}
