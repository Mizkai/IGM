using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartBar : MonoBehaviour
{ 
    public int health;
    public int numOfHearts;

    public Image[] HeartImages;
    public Sprite Heartfill;
    public Sprite Heartborder;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(health>numOfHearts)
        {
            health = numOfHearts;
        }
        for (int i = 0; i < HeartImages.Length; i++)
        {
            if(i<health)
            {
                HeartImages[i].sprite = Heartfill;
            }
            else
            {
                HeartImages[i].sprite = Heartborder; 
            }
            if(i<numOfHearts)
            {
                HeartImages[i].enabled = true;
            }
            else
            {
                HeartImages[i].enabled = false;
            }

        }
    }

    public void HealthGoDown()
    {
        health--;

    }
}
