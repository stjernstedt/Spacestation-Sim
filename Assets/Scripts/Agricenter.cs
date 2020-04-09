using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agricenter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		ResourceProducer producer = GetComponent<ResourceProducer>();
		producer.AddCost(ResourceTypes.fertilizer, 1);
    }

    // Update is called once per frame
    void Update()
    {
		
    }
}
