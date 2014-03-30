using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour 
{
	bool email;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		email = GameObject.FindGameObjectWithTag("Email").GetComponent<Email>().email;
		if(email == true)
		{
			transform.position = new Vector3(17, 1, -10);
		}
	}
}
