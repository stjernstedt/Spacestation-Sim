using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceProducer : MonoBehaviour
{
	Resources resources;
	public ResourceTypes type;

	float timePassed;

    // Start is called before the first frame update
    void Start()
    {
		resources = GetComponentInParent<Resources>();
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
		resources.AddResource(type, 1);
	}
}
