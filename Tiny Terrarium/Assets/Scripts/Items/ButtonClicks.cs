using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicks : MonoBehaviour
{

    public int clickCount = 0; 

    // Start is called before the first frame update
    public void ButtonClick()
    {
        clickCount++;
    }
}
