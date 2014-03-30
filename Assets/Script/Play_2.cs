using UnityEngine;
using System.Collections;

public class Play_2 : MonoBehaviour 
{

	bool vai;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		vai = GameObject.FindGameObjectWithTag("Play").GetComponent<Play>().ia;
		if(vai == true)
		{
			renderer.enabled = true;
		}
		if(vai == false)
		{
			renderer.enabled = false;
		}
	}
}
