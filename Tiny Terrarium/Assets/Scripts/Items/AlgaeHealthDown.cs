using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgaeHealthDown : MonoBehaviour
{

    public healthplayer hp;
    //public DialogueManager dm;

    void Start()
    {
        InvokeRepeating("MakeHealthGoDown", 5.0f, 3.0f);
    }

    void onDestroy()
    {
        CancelInvoke();
    }

    void MakeHealthGoDown()
    {
        hp.HealthGoDown(); 
        //heartManager.UpdateHearts(-1);

    }

}