using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelClose : MonoBehaviour
{

    public GameObject panel;

    // attach to button
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnClick()
    {
        panel.SetActive(false); //panel hidden 

    }
}
