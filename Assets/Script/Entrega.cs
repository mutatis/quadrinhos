using UnityEngine;
using System.Collections;

public class Entrega : MonoBehaviour 
{
	public static Entrega instance;

	public int revista = 10;

	bool colocar;
	
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
		colocar = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().ok;
		if(colocar == false && Input.GetKeyDown(KeyCode.Space))
		{
			revista --;
		}
	}

	void OnMouseDown()
	{
		revista = 10;
	}
}
