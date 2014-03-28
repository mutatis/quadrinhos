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

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.tag == "Escada")
		{
			escada = true;
		}
		if(other.tag == "Parede_baixo")
		{
			escada = false;
		}
		if(other.tag == "Blin")
		{
			blin = false;
		}
		if(other.tag == "Foca")
		{
			foca = false;
		}
		if(other.tag == "Gamer")
		{
			gamer = false;
		}
		if(other.tag == "Gordice")
		{
			gordice = false;
		}
		if(other.tag == "Kaboom")
		{
			kaboom = false;
		}
		if(other.tag == "Miau")
		{
			miau = false;
		}
		if(other.tag == "Scream")
		{
			scream = false;
		}
		if(other.tag == "Rock")
		{
			rock = false;
		}
		if(other.tag == "Spaghetti")
		{
			spaghetti = false;
		}
		if(other.tag == "Spencer")
		{
			spencer = false;
		}
		if(other.tag == "Square")
		{
			square = false;
		}
		if(other.tag == "Survivors")
		{
			survivors = false;
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{

		if(other.tag == "Blin")
		{
			blin = true;
		}
		if(other.tag == "Foca")
		{
			foca = true;
		}
		if(other.tag == "Gamer")
		{
			gamer = true;
		}
		if(other.tag == "Gordice")
		{
			gordice = true;
		}
		if(other.tag == "Kaboom")
		{
			kaboom = true;
		}
		if(other.tag == "Miau")
		{
			miau = true;
		}
		if(other.tag == "Scream")
		{
			scream = true;
		}
		if(other.tag == "Rock")
		{
			rock = true;
		}
		if(other.tag == "Spaghetti")
		{
			spaghetti = true;
		}
		if(other.tag == "Spencer")
		{
			spencer = true;
		}
		if(other.tag == "Square")
		{
			square = true;
		}
		if(other.tag == "Survivors")
		{
			survivors = true;
		}
	}
}
