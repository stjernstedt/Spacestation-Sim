using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
	public GameObject hq;
	public GameObject fertilizerText;
	public GameObject foodText;
	public GameObject electronicsText;

	float timePassed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		timePassed += Time.deltaTime;
		if (timePassed > 1)
		{
			UpdateResources();
			timePassed = 0;
		}
    }

	void UpdateResources()
	{
		fertilizerText.GetComponent<Text>().text = "Fertilizer: " + hq.GetComponent<Resources>().fertilizer;
		foodText.GetComponent<Text>().text = "Food: " + hq.GetComponent<Resources>().food;
		electronicsText.GetComponent<Text>().text = "Electronics: " + hq.GetComponent<Resources>().electronics;
	}
}
