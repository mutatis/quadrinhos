using UnityEngine;
using System.Collections;

public class Credito : MonoBehaviour 
{

	public int type;

	public bool ia;

	public static Credito instance;

	void Awake()
	{
		instance = this;	
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(ia == true)
		{
			renderer.enabled = false;
		}
		if(ia == false)
		{
			renderer.enabled = true;
		}
	}

	void OnMouseDown()
	{
		Application.LoadLevel("Creditos");
	}

	void OnMouseOver()
	{
		ia = true;
	}

	void OnMouseExit()
	{
		ia = false;
	}
}
