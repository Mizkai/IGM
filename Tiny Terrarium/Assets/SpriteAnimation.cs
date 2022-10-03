using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimation : MonoBehaviour
{
    // In animation controller, add idle state. 
    //Right click and add transition between idle state and animation.
    //In parameters, click the +button and add a trigger, call it active.
    //Click on the transition link and un-check exit time, and add the condition Active.
    //Add this code to a script attached to the same object the animator controller is in the scene or link it via a public variable.

    Animator anim;
 
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Active");
        }
    }
}
