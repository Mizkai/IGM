using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//want this to check how many times object has been clicked within a time period, and add or take away health

 public class FishHealth : MonoBehaviour
{
    public healthplayer hp;
    public ButtonClicks bc; 
    

    public void Start()
    {
        InvokeRepeating("DoCheck", 1.0f, 10.0f);
    }

    void DoCheck()
    {
        bc = GameObject.Find("TestButton").GetComponent<ButtonClicks>();
        hp = GameObject.Find("Health").GetComponent<healthplayer>();

        if (bc.clickCount == 1)
        {
            hp.currentHealth = hp.currentHealth + 1;
            bc.clickCount = 0;

            Debug.Log("Fish: 1 click");
        }
        else
        {
            hp.currentHealth = hp.currentHealth - 10;
            bc.clickCount = 0;

            Debug.Log("Fish: no or too many clicks");
        }
     } 
}