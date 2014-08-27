using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour 
{
    public GameObject children;
    public enum Item
    {
        Flashlight,
        Battery
    }   

    public Item item;

    void OnTriggerEnter()
    {
        if (item == Item.Flashlight)
        {
            // GameObject.SetActiveRecursively(true) is now obsolete. This line is in the video but it should be 
            // The other major change related to this is to make both child elements enabled in the Inspector before you run the game
            // In the Flashlight.cs script we find the object, assign it to the static variable and immediately deactivate it. 
            // Here, we are setting them all to active. 
            Flashlight.HeadlightMount.SetActive(true);

            HUD.HasFlashlight = true;
        }
        else
            HUD.BatteryCount++;

        Destroy(gameObject);
    }
}