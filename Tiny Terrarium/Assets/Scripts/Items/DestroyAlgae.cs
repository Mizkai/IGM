using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAlgae : MonoBehaviour
{
    //this script works, attach script to "algae cleaner" and add "algae" to variable field

    public GameObject objectToDestroy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        Destroy(objectToDestroy);
    }
}