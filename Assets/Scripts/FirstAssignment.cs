using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAssignment
{
	void IncreaseInt (int num)
	{
		num++;
		Debug.Log ($"The result is {num}");
	}
	
	void PrintInfo (int num)
	{
		if (num > 100000)
			Debug.Log ("Wow, this number is big!");
		else
			Debug.Log ("There are bigger numbers");
	}
	
	void MyFirstCase (int num)
	{
		switch (num % 3)
		{
			case 0:
				Debug.Log("This number is divisible by 3");
				break;
			case 1:
				Debug.Log("If you devide it by 3 you'll get a reminder of 1");
				break;
			default:
				Debug.Log("If you devide it by 3 you'll get a reminder of 2");
				break;
		}
	}
	


}
