using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



//want this to check how many times object has been clicked within a time period, and add or take away health

public class FishHealth : MonoBehaviour
{
    public HeartBar hp;
    public ButtonClicks bc; 
    

    public void Start()
    {
        InvokeRepeating("DoCheck", 30.0f, 120.0f);
    }

    void DoCheck()
    {

        //  bc = GameObject.Find("FishButton").GetComponent<ButtonClicks>(); this stopped working, possibly because I made the button the child of the panel-connected it manually in inspector
        hp = GameObject.Find("Health").GetComponent<HeartBar>();

        if (bc.clickCount == 1)
        {
            hp.health = hp.health + 1;
            bc.clickCount = 0;

            Debug.Log("Fish: 1 click");
        }
        else
        {
            hp.health = hp.health - 1;
            bc.clickCount = 0;

            Debug.Log("Fish: no or too many clicks");
        }
     } 
}