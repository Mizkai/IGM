using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//want this to check how many times object has been clicked within a time period, and add or take away health

 public class FishHealth : MonoBehaviour
{
    public int clickCount = 0;
    public healthplayer hp;
    public OnClick onClick;

    void Start()
    {
        onClick = GameObject.Find("Fish").GetComponent<OnClick>();
        
        InvokeRepeating("DoCheck", 1.0f, 10.0f);
    }

    void DoCheck()
    {
        if (clickCount == 1)
        {
            hp.currentHealth = hp.currentHealth + 1;
            Debug.Log("1 click-gain health");
        }
        else
        {
            hp.currentHealth = hp.currentHealth - 10;
            Debug.Log("No clicks-lose health");
        }
     } 
}