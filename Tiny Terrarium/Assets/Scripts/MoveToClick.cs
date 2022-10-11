using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToClick : MonoBehaviour
{
    private Vector2 target;   
    
    // Update is called once per frame
    void Update()
    {
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
        {
            target = new Vector2(mousepos.x, mousepos.y);
        }

        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5f);
    }
}
