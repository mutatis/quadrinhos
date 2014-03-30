using UnityEngine;
using System.Collections;

public class Colocar : MonoBehaviour 
{
	public int revista;
	public int n_revista;

	public static Colocar instance;
	
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
		if(Input.GetKeyDown("z"))
		{
			revista ++;
		}
		if(revista > 12)
		{
			revista = 1;
		}
		if(revista == 1 && n_revista == 1)
		{
			renderer.enabled = true;
		}
		if(revista == 1 && n_revista != 1)
		{
			renderer.enabled = false;
		}
		if(revista == 2 && n_revista == 2)
		{
			renderer.enabled = true;
		}
		if(revista == 2 && n_revista != 2)
		{
			renderer.enabled = false;
		}
		if(revista == 3 && n_revista == 3)
		{
			renderer.enabled = true;
		}
		if(revista == 3 && n_revista != 3)
		{
			renderer.enabled = false;
		}
		if(revista == 4 && n_revista == 4)
		{
			renderer.enabled = true;
		}
		if(revista == 4 && n_revista != 4)
		{
			renderer.enabled = false;
		}
		if(revista == 5 && n_revista == 5)
		{
			renderer.enabled = true;
		}
		if(revista == 5 && n_revista != 5)
		{
			renderer.enabled = false;
		}
		if(revista == 6 && n_revista == 6)
		{
			renderer.enabled = true;
		}
		if(revista == 6 && n_revista != 6)
		{
			renderer.enabled = false;
		}
		if(revista == 7 && n_revista == 7)
		{
			renderer.enabled = true;
		}
		if(revista == 7 && n_revista != 7)
		{
			renderer.enabled = false;
		}
		if(revista == 8 && n_revista == 8)
		{
			renderer.enabled = true;
		}
		if(revista == 8 && n_revista != 8)
		{
			renderer.enabled = false;
		}
		if(revista == 9 && n_revista == 9)
		{
			renderer.enabled = true;
		}
		if(revista == 9 && n_revista != 9)
		{
			renderer.enabled = false;
		}
		if(revista == 10 && n_revista == 10)
		{
			renderer.enabled = true;
		}
		if(revista == 10 && n_revista != 10)
		{
			renderer.enabled = false;
		}
		if(revista == 11 && n_revista == 11)
		{
			renderer.enabled = true;
		}
		if(revista == 11 && n_revista != 11)
		{
			renderer.enabled = false;
		}
		if(revista == 12 && n_revista == 12)
		{
			renderer.enabled = true;
		}
		if(revista == 12 && n_revista != 12)
		{
			renderer.enabled = false;
		}
	}
}
