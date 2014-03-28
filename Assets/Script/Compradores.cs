using UnityEngine;
using System.Collections;

public class Compradores : MonoBehaviour 
{
	public int gordice_on;
	public int gamer_on;
	public int kaboom_on;
	public int scream_on;
	public int spencer_on;

	public static Compradores instance;

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
		transform.Translate(0.1f, 0, 0);
	}
}