using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//want this to check how many times object has been clicked within a 3m period, and add or take away health
//is there a way to do, if "on" for a certain amount of time

public class CoroutineLight : MonoBehaviour
{
    public int clickCount = 0;

    IEnumerator DoCheck()
    {
        for (; ; )
        {
            if (clickCount = 2)
            {
                health = currentHealth + 1;
            }
            else
            {
                health = currentHealth - 1;
            }
            yield return new WaitForSeconds(180f); //3 minutes
        }
    }
}