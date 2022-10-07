using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//want this to check how many times object has been clicked within a time period, and add or take away health

public class LightHealth : MonoBehaviour
{
    public HeartBar hp;
    public ButtonClicks bc;


    public void Start()
    {
        InvokeRepeating("DoCheck", 30.0f, 70.0f);
    }

    void DoCheck()
    {
     //   bc = GameObject.Find("LightButton").GetComponent<ButtonClicks>(); this stopped working, possibly because I made the button the child of the panel-connected it manually in inspector instead
        hp = GameObject.Find("Health").GetComponent<HeartBar>();

        if (bc.clickCount == 2)
        {
            hp.health = hp.health + 1;
            bc.clickCount = 0;

            Debug.Log("Light: 2 clicks");
        }
        else
        {
            hp.health = hp.health - 1;
            bc.clickCount = 0;

            Debug.Log("Light: no or too many clicks");
        }
    }
}