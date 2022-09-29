using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class Spoons : MonoBehaviour

{

    public int spoons = 1;
    private bool tired;
    private int spoonbar;

    public Image[] SpoonImages;

    // Start is called before the first frame update

    void Start()

    {

        int r = Random.Range(0, SpoonImages.Length);
        //
        spoonbar = SpoonImages.Length;
        //

        UpdateSpoons(r - spoons);

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

    public void UpdateSpoons(int ChangeInSpoons) // ensure the visualisation of the spoons matches the actual number

    {

        spoons += ChangeInSpoons;

        // turn off the image component in each 'spoonImage'

        foreach (Image spoonImage in SpoonImages)

        {

            spoonImage.enabled = false;

        }

        //Turns on a number of spoons equal to 'spoons'

        for (int i = 0; i < SpoonImages.Length; i++)

        {

            if (spoons-1 >= i)

            {
                SpoonImages[i].enabled = true;

            }

        

            else if (spoons-1 <i )
            {
                    tired = true;
            }
    }

    }

}