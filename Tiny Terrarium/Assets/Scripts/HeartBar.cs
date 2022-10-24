using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//new code
using UnityEngine.SceneManagement;


public class HeartBar : MonoBehaviour
{ 
    public int health;
    public int numOfHearts;

    public Image[] HeartImages;
    public Sprite Heartfill;
    public Sprite Heartborder;
    private bool clicked;
    public string sceneToLoad;




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

        if (health <= 0) //restart game...opens panel when health drops to 0
        {
            SceneManager.LoadScene("GameOver");

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
