using UnityEngine;
using System.Collections;

public class Email : MonoBehaviour 
{
	public bool email;

	public static Email instance;
	
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
		email = true;
	}
}
