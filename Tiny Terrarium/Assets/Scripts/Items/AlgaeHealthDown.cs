using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgaeHealthDown : MonoBehaviour
{
    //this script goes on the algaePrefab, make sure to connect healthplayer script in inspector
    public healthplayer hp;

    void Start()
    {
        InvokeRepeating("MakeHealthGoDown", 5.0f, 3.0f);
    }

    void onDestroy()
    {
        CancelInvoke();
    }

    void MakeHealthGoDown()
    {
        hp.HealthGoDown();
        Debug.Log("Health go down");


    }

}