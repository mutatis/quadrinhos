using UnityEngine;
using System.Collections;

public class Revista : MonoBehaviour 
{
	public GameObject gordice;
	public GameObject gamer;
	public GameObject kaboom;
	public GameObject scream;
	public GameObject spencer;
	public GameObject blin;
	public GameObject foca;
	public GameObject miau;
	public GameObject rock;
	public GameObject spaghetti;
	public GameObject square;
	public GameObject survivors;

	public bool gordice_on;
	public bool gamer_on;
	public bool kaboom_on;
	public bool scream_on;
	public bool spencer_on;
	public bool blin_on;
	public bool foca_on;
	public bool miau_on;
	public bool rock_on;
	public bool spaghetti_on;
	public bool square_on;
	public bool survivors_on;

	bool gordice_off;
	bool gamer_off;
	bool kaboom_off;
	bool scream_off;
	bool spencer_off;
	bool blin_off;
	bool foca_off;
	bool miau_off;
	bool rock_off;
	bool spaghetti_off;
	bool square_off;
	bool survivors_off;

	int gordice_v;
	int gamer_v;
	int kaboom_v;
	int scream_v;
	int spencer_v;
	int blin_v;
	int foca_v;
	int miau_v;
	int rock_v;
	int spaghetti_v;
	int square_v;
	int survivors_v;

	int pontos;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		gordice_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().gordice;
		gamer_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().gamer;
		kaboom_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().kaboom;
		scream_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().scream;
		blin_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().blin;
		foca_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().foca;
		miau_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().miau;
		rock_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().rock;
		spaghetti_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().spaghetti;
		spencer_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().spencer;
		square_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().square;
		survivors_off = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().survivors;

		if(gordice_on == false && gordice_off == false)
		{
			gordice.SetActive(true);
			gordice_on = true;
		}
		if(gamer_on == false && gamer_off == false)
		{
			gamer.SetActive(true);
			gamer_on = true;
		}
		if(kaboom_on == false && kaboom_off == false)
		{
			kaboom.SetActive(true);
			kaboom_on = true;
		}
		if(scream_on == false && scream_off == false)
		{
			scream.SetActive(true);
			scream_on = true;
		}
		if(blin_on == false && blin_off == false)
		{
			blin.SetActive(true);
			blin_on = true;
		}
		if(foca_on == false && foca_off == false)
		{
			foca.SetActive(true);
			foca_on = true;
		}
		if(miau_on == false && miau_off == false)
		{
			miau.SetActive(true);
			miau_on = true;
		}
		if(rock_on == false && rock_off == false)
		{
			rock.SetActive(true);
			rock_on = true;
		}
		if(spaghetti_on == false && spaghetti_off == false)
		{
			spaghetti.SetActive(true);
			spaghetti_on = true;
		}
		if(spencer_on == false && spencer_off == false)
		{
			spencer.SetActive(true);
			spencer_on = true;
		}
		if(square_on == false && square_off == false)
		{
			square.SetActive(true);
			square_on = true;
		}
		if(survivors_on == false && survivors_off == false)
		{
			survivors.SetActive(true);
			survivors_on = true;
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.tag == "Comprador")
		{
			gordice_v = Random.Range(0, 3);
			gamer_v = Random.Range(0, 3);
			kaboom_v = Random.Range(0, 3);
			scream_v = Random.Range(0, 3);
			spencer_v = Random.Range(0, 3);
			blin_v = Random.Range(0, 3);
			foca_v = Random.Range(0, 3);
			miau_v = Random.Range(0, 3);
			rock_v = Random.Range(0, 3);
			spaghetti_v = Random.Range(0, 3);
			square_v = Random.Range(0, 3);
			survivors_v = Random.Range(0, 3);
		}

		if(survivors_v == 1)
		{
			if(survivors_on == true)
			{
				survivors.SetActive(false);
				survivors_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
			
		}
		if(square_v == 1)
		{
			if(square_on == true)
			{
				square.SetActive(false);
				square_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
			
		}
		if(spaghetti_v == 1)
		{
			if(spaghetti_on == true)
			{
				spaghetti.SetActive(false);
				spaghetti_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
			
		}
		if(rock_v == 1)
		{
			if(rock_on == true)
			{
				rock.SetActive(false);
				rock_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
			
		}
		if(miau_v == 1)
		{
			if(miau_on == true)
			{
				miau.SetActive(false);
				miau_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
			
		}
		if(gordice_v == 1)
		{
			if(gordice_on == true)
			{
				gordice.SetActive(false);
				gordice_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
			
		}
		if(foca_v == 1)
		{
			if(foca_on == true)
			{
				foca.SetActive(false);
				foca_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
			
		}
		if(blin_v == 1)
		{
			if(blin_on == true)
			{
				blin.SetActive(false);
				blin_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
			
		}
		if(gamer_v == 1)
		{
			if(gamer_on == true)
			{
				gamer.SetActive(false);
				gamer_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
		}
		if(kaboom_v == 1)
		{
			if(kaboom_on == true)
			{
				kaboom.SetActive(false);
				kaboom_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
		}
		if(scream_v == 1)
		{
			if(scream_on == true)
			{
				scream.SetActive(false);
				scream_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
		}
		if(spencer_v == 1)
		{
			if(spencer_on == true)
			{
				spencer.SetActive(false);
				spencer_on = false;
				pontos ++;
			}
			else
			{
				pontos --;
			}
		}
	}
}