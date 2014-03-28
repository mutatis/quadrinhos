using UnityEngine;
using System.Collections;

public class Back_intro : MonoBehaviour 
{

	//Oi!! Aqui eu começo.
	// Use this for initialization
	void Start () 
	{
	
	}


	// Update is called once per frame
	void Update () 
	{
	
	}
	//Esta função verifica se o jogador clicou com o mouse no botão.
	void OnMouseDown()
	{
		//Se o player clicou vai para cena tal.
		Application.LoadLevel("Intro");
	}
}
