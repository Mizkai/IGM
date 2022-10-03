using UnityEngine;
using System.Collections;

//this might make an object appear if it is attached to it???

public class PondScum : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(TankScum());
    }

    IEnumerator TankScum()
    {
        while (true)
        {
            yield return new WaitForSeconds(50);
        }
    }

}