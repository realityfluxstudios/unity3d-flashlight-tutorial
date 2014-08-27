using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour 
{
	public static int BatteryCount;
	public static bool HasFlashlight;
	
	void OnGUI()
	{
		if(HasFlashlight)
		{
		    GUI.Label(new Rect(10, 10, 80, 30), "Flashlight");
		    GUI.Label(new Rect(70, 10, 80, 30), Flashlight.BatteryLife.ToString("F2"));
		}

	    GUI.Label(new Rect(10, 40, 80, 30), "Batteries");
	    GUI.Label(new Rect(70, 40, 80, 30), BatteryCount.ToString());
	}
}