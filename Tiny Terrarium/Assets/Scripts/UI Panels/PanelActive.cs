using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PanelActive : MonoBehaviour
{

    public GameObject panel; //lets us choose which panel in the inspector

    void Start()
    {
        panel.SetActive(false); //panel hidden when game starts
    }

    void OnMouseDown() //when this item collider is clicked
    {
        if (panel != null) //I think this means, if panel is off turn on...idk this lets you turn it on and off but we only need it to turn on
        {
            panel.SetActive(!panel.activeSelf);
        }

    }

}
