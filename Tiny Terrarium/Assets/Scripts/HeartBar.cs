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
    private bool clicked;



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

        if (Input.GetMouseButtonUp (0))
        {
            clicked = true;
        }
    }

    public void HealthGoDown()
    {
        health--;

    }

    public void HealthIncrease()
    {
        if (clicked)
        health++;
    }
}
