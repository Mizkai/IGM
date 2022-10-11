using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    }

    // Update is called once per frame
    private void PrintName (GameObject go)
    {
        print(go.name);
    }
}
