using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsGenerator : MonoBehaviour
{
    public GameObject floor, container, instantiatedObject;
    public GameObject[] myObjects;
    public int goQuantity, randomIndex;
    public float minRange, maxRange;
    public Vector3 randomPos;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < goQuantity; i++)
        {
            randomIndex = Random.Range(0, myObjects.Length);
            randomPos = new Vector3(Random.Range(minRange, maxRange), 0, Random.Range(minRange, maxRange));

            instantiatedObject = Instantiate(myObjects[randomIndex], randomPos, Quaternion.identity) as GameObject;
            /* instantiatedObject.transform.parent = container.transform; */

        }
    }
}
