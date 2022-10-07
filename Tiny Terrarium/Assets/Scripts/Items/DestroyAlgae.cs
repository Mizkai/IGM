using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyAlgae : MonoBehaviour
{
    //this script works, attach script to "algae cleaner" and add "algae" to variable field

   // public GameObject objectToDestroy;
    private GameObject go;

    // Start is called before the first frame update
    void Update() //update, not start...only 1 respawn under start
    {
        go = GameObject.FindWithTag("Respawn");//destroy object tagged Respawn
    }

    // Update is called once per frame

    public void OnMouseDown()
    {
        Destroy(go);
    }
}