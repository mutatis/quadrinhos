using UnityEngine;
using System.Collections;

public class Animate : MonoBehaviour 
{
	//Crio variaveis.
	float ai;
	public int ai_animate;
	bool muda;
	bool email;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		email = GameObject.FindGameObjectWithTag("Email").GetComponent<Email>().email;
		//coloco a variavel ai igual a variavel de outra classe.
		ai = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().posicao_x;

		if(email == false)
		{
			//verifico se o valor das variaveis e dou uma ordem.
			if(ai == 0 && ai_animate == 1)
			{
				renderer.enabled = false;
			}
			//se nao faça outra coisa.
			else
			{
				renderer.enabled = true;
			}
			if(ai < 0 || ai > 0)
			{
				if(ai != 0 && ai_animate == 2)
				{
					renderer.enabled = false;
				}
				else
				{
					renderer.enabled = true;
				}
			}

			if (ai < 0 && !muda)
				Flip ();
			else if (ai > 0 && muda)
				Flip ();
		}
	}
	void Flip()
	{
		muda = !muda;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;		
	}
}