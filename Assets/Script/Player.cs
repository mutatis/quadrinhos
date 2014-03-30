using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{	
	public float posicao_x;

	public static Player instance;

	public bool escada = false;

	public float pos_x;

	public bool blin;
	public bool foca;
	public bool gamer;
	public bool gordice;
	public bool kaboom;
	public bool miau;
	public bool scream;
	public bool rock;
	public bool spaghetti;
	public bool spencer;
	public bool square;
	public bool survivors;
	public bool ok;

	bool email;

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
		email = GameObject.FindGameObjectWithTag("Email").GetComponent<Email>().email;
		if(email == false)
		{
			posicao_x = Input.GetAxis("Horizontal");
			transform.Translate(posicao_x, 0, 0);

			pos_x = transform.position.x;

			if(Input.GetKey(KeyCode.UpArrow) && escada == true)
			{
				transform.Translate(posicao_x, 0.1f, 0);
			}
			if(Input.GetKey(KeyCode.DownArrow) && escada == true)
			{
				transform.Translate(posicao_x, -0.1f, 0);
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(email == false)
		{
			if(other.tag == "Escada")
			{
				escada = true;
				ok = true;
			}
			if(other.tag == "Parede_baixo")
			{
				escada = false;
				ok = true;
			}
			if(other.tag == "Blin")
			{
				blin = false;
				ok = true;
			}
			if(other.tag == "Foca")
			{
				foca = false;
				ok = true;
			}
			if(other.tag == "Gamer")
			{
				gamer = false;
				ok = true;
			}
			if(other.tag == "Gordice")
			{
				gordice = false;
				ok = true;
			}
			if(other.tag == "Kaboom")
			{
				kaboom = false;
				ok = true;
			}
			if(other.tag == "Miau")
			{
				miau = false;
				ok = true;
			}
			if(other.tag == "Scream")
			{
				scream = false;
				ok = true;
			}
			if(other.tag == "Rock")
			{
				rock = false;
				ok = true;
			}
			if(other.tag == "Spaghetti")
			{
				spaghetti = false;
				ok = true;
			}
			if(other.tag == "Spencer")
			{
				spencer = false;
				ok = true;
			}
			if(other.tag == "Square")
			{
				square = false;
				ok = true;
			}
			if(other.tag == "Survivors")
			{
				survivors = false;
				ok = true;
			}
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if(email == false)
		{
			if(other.tag == "Blin")
			{
				blin = true;
				ok = false;
			}
			if(other.tag == "Foca")
			{
				foca = true;
				ok = false;
			}
			if(other.tag == "Gamer")
			{
				gamer = true;
				ok = false;
			}
			if(other.tag == "Gordice")
			{
				ok = false;
				gordice = true;
			}
			if(other.tag == "Kaboom")
			{
				kaboom = true;
				ok = false;
			}
			if(other.tag == "Miau")
			{
				miau = true;
				ok = false;
			}
			if(other.tag == "Scream")
			{
				scream = true;
				ok = false;
			}
			if(other.tag == "Rock")
			{
				rock = true;
				ok = false;
			}
			if(other.tag == "Spaghetti")
			{
				spaghetti = true;
				ok = false;
			}
			if(other.tag == "Spencer")
			{
				spencer = true;
				ok = false;
			}
			if(other.tag == "Square")
			{
				square = true;
				ok = false;
			}
			if(other.tag == "Survivors")
			{
				survivors = true;
				ok = false;
			}
		}
	}
}
