using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class Hearts : MonoBehaviour

{

    public int hearts = 1;
    private bool tired;
    private int heartbar;

    public Image[] HeartImages;

    // Start is called before the first frame update

    void Start()

    {

        // int r = Random.Range(0, HeartImages.Length);
        // //
         heartbar = HeartImages.Length;
        // //

        // UpdateHearts(r - hearts);

    }
  //
    void update()
    {
        if (tired == true) 
        {
              Debug.Log("i'm tired"); 
        }

    }
  //

    public void UpdateHearts(int ChangeInHearts) // ensure the visualisation of the hearts matches the actual number

    {

        hearts += ChangeInHearts;

        // turn off the image component in each 'heartImage'

        foreach (Image heartImage in HeartImages)

        {

            heartImage.enabled = false;

        }

        //Turns on a number of hearts equal to 'hearts'

        for (int i = 0; i < HeartImages.Length; i++)

        {

            if (hearts-1 >= i)

            {
                HeartImages[i].enabled = true;

            }

        

            else if (hearts-1 <i )
            {
                    tired = true;
            }
    }

    }

}