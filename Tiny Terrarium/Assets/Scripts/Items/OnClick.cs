using UnityEngine;
using UnityEngine.EventSystems;

public class OnClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{


//Detect current clicks on the GameObject (the one with the script attached)
//must add physicsraycaster component to camera
public void OnPointerDown(PointerEventData pointerEventData)
    {

        //Output the name of the GameObject that is being clicked
        Debug.Log(name + "Game Object Click in Progress");
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        Debug.Log(name + "No longer being clicked");
    }


}