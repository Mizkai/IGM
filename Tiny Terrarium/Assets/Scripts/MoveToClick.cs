using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToClick : MonoBehaviour
{
    private Vector3 target;   
    
    // Update is called once per frame
    void Update()
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
        {
            target = new Vector3(mousepos.x, mousepos.y, mousepos.z);
        }

        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 5f);
    }
}
