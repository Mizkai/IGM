using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//want this to check how many times object has been clicked within a 3m period, and add or take away health

 public class FishHealth : MonoBehaviour
{
    public int clickCount = 0;
    public healthplayer hp;
    //public DialogueManager dm;

    void Start()
    {
        InvokeRepeating("DoCheck", 90.0f, 90.0f);
    }

    public void DoCheck()
     {
        if (clickCount == 3)
        {
            hp.currentHealth = hp.currentHealth + 1;
            //heartManager.UpdateHearts(+1);
            Debug.Log("3 clicks get health");
        }
        else
        {
            hp.currentHealth = hp.currentHealth - 1;
            //heartManager.UpdateHearts(-1);
            Debug.Log("Not enough clicks lose health");
        }
     }
}