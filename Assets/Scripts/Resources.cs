using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ResourceTypes
{
	food,
	fertilizer
}

public class Resources : MonoBehaviour
{

	public int food;
	public int fertilizer;


	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void AddResource(ResourceTypes type, int amount)
	{
		switch (type)
		{
			case ResourceTypes.food:
				food += amount;
				break;
			case ResourceTypes.fertilizer:
				break;
			default:
				break;
		}
	}
}
