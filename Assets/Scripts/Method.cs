using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour
{
	void Start()
	{
		int x = 5;
		int y = 7;

		x += y;
		y += x;

		int difference = x - y;
		Debug.Log($"diffrence is {difference}");

		if (x == y)
		{
			Debug.Log("x and y are now equal, what are the odds?");
		}
	}
}