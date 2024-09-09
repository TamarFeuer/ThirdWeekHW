using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
	int currentFloor = 0;
	bool isShabat = false;
	
	void GoUp(int howManyFloors)
	{
		if (currentFloor + howManyFloors <= 7)
		{
			currentFloor += howManyFloors;
			Debug.Log ($"Elevator went up and reached floor number {currentFloor}");
		}
	}
	
	void GoDown(int howManyFloors)
	{
		if (currentFloor - howManyFloors >= -1)
		{
			currentFloor -= howManyFloors;
			Debug.Log ($"Elevator went down and reached floor number {currentFloor}");
		}
	}
	
	void DoShabatStuff()
	{
		while (isShabat)
		{
			//Discovered unity can't cope with infinite loops
			//Tried limiting it with number of cycles, but this too was too hard on unity
			//Debug.Log ("Elevator goes up until floor number 7 and then all the way down to floor number -1, stopping on each floor"); ?
   // great discovery. it can cope with them, just need to divide them amongst frames, otherwise it will be one endless frame. try read about coroutines.
		}

	}

	void Start()
	{
		if(isShabat)
			DoShabatStuff();
		else
		{
			GoUp(3);
			GoDown(2);
		}
	}
}
