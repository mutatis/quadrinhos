using UnityEngine;
using System.Collections;

public class Credito_2 : MonoBehaviour 
{

	bool vai;	

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		vai = GameObject.FindGameObjectWithTag("Creditos").GetComponent<Credito>().ia;
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
