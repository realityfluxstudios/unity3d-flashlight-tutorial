using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour
{
	public static float BatteryLife = 100;
	public static GameObject HeadlightMount;

	public Light HeadLight;

	public float BatteryReductionSpeed = 3.0f;
	
	void Awake()
	{
        // We find the game object with the 'Headlamp' tag and assign it to a static variable (static so that we can access it in another script) 
	    HeadlightMount = GameObject.FindWithTag("Headlamp");
        // we deactivate it, which in turn, deactivates it's children
        HeadlightMount.SetActive(false);
        // turns off the light component
		HeadLight.enabled = false;
	}

	void Update()
	{
		if (HeadLight.enabled)
		{
			BatteryLife = BatteryLife - (BatteryReductionSpeed * Time.deltaTime);
		}

		if (Input.GetKeyDown(KeyCode.Tab) && HUD.HasFlashlight && !HeadLight.enabled && HUD.BatteryCount > 0)
		{
			if (BatteryLife <= 0 && HUD.BatteryCount > 0)
			{
				HUD.BatteryCount--;
				BatteryLife = 100;
			}

			HeadLight.enabled = true;
		}
		else if (Input.GetKeyDown(KeyCode.Tab) && HUD.HasFlashlight && HeadLight.enabled)
		{
			HeadLight.enabled = false;
		}

		if (BatteryLife <= 0)
		{
			BatteryLife = 0;
			HeadLight.enabled = false;
		}
	}
}