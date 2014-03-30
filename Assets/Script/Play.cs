using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour 
{
	public bool ia;

	public static Play instance;
	
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
	
	}

	void OnMouseDown()
	{
		Application.LoadLevel("Game");
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
