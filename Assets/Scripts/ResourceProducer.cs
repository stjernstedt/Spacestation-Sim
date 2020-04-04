using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceProducer : MonoBehaviour
{
	GameObject core;
	public ResourceTypes type;

	float timePassed;

    // Start is called before the first frame update
    void Start()
    {
		core = FindObjectOfType<Core>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
		timePassed += Time.deltaTime;
		if(timePassed > 1)
		{
			ProduceResource();
			timePassed = 0;
		}
    }

	void ProduceResource()
	{
		core.GetComponent<Resources>().AddResource(type, 1);
	}
}
