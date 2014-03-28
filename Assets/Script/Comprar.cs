using UnityEngine;
using System.Collections;

public class Comprar : MonoBehaviour 
{
	public GameObject compradores;
	float tempo = 1.2f;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Time.time >= tempo)
		{
			tempo = (Random.Range(3f, 6f)) + Time.time;
			Instantiate(compradores, new Vector2(-6, -1), transform.rotation);
		}
	}
}