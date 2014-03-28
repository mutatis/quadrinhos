using UnityEngine;
using System.Collections;

public class Parede_falsa : MonoBehaviour 
{
	public bool vai;

	public static Parede_falsa instance;

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

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag =="Comprador")
		{
			vai = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.tag =="Comprador")
		{
			vai = false;
		}
	}
}
