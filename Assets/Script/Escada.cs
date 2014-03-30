using UnityEngine;
using System.Collections;

public class Escada : MonoBehaviour 
{
	bool ai_escada;
	float ai;
	bool pos_x;
	bool posicao_x;
	float ai_x;
	bool email;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		ai_escada = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().escada;
		ai = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().posicao_x;
		ai_x = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().pos_x;
		email = GameObject.FindGameObjectWithTag("Email").GetComponent<Email>().email;

		if(email == false)
		{
			if(ai_escada == true)
			{
				/*if(pos_x == true && ai > 0)
				{
					transform.Translate(0, 0, 0);
				}
				if(pos_x == true && ai < 0)
				{
					transform.Translate(ai, 0, 0);
				}
				if(posicao_x == true && ai < 0)
				{
					transform.Translate(0, 0, 0);
				}
				if(posicao_x == true && ai > 0)
				{
					transform.Translate(ai, 0, 0);
				}*/
				if(pos_x == false || posicao_x == false)
				{
					transform.position = new Vector2((ai_x - 5.5f), 1.149109f);
				}
				transform.Translate(ai, 0, 0);
			}
			if(ai_escada == false)
			{
				transform.Translate(0, 0, 0);
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(email == false)
		{
			if(other.tag == "Finish")
			{
				pos_x = false;
			}
			if(other.tag == "left")
			{
				posicao_x = false;
			}
		}
	}
	void OnTrigerExit2D (Collider2D other)
	{
		if(email == false)
		{
			if(other.tag == "Finish")
			{
				pos_x = true;
			}
			if(other.tag == "left")
			{
				posicao_x = true;
			}
		}
	}
}
