﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour {



	//code which is triggered when the button is pressed
	public void easy()
	{
		SceneManager.LoadScene ("lvl1");
	}
	public void medium()
	{
		SceneManager.LoadScene ("lvl2");
	}
	public void hard()
	{
		SceneManager.LoadScene ("lvl3");
	}
	public void Instructions()
	{
		SceneManager.LoadScene ("instructions");
	}


	public void exitmenu()
	{
		Application.Quit();
	}



	public void menu()
	{
		SceneManager.LoadScene ("menu");
	}
		

	//trigger animations parameters
	public void bottles()
	{
		//the name of the trigger to happen when button is pressed in the animator
		GameObject.Find("Bottle2").GetComponent<Animator>().SetTrigger("bottle2");
		GameObject.Find("Bottle1").GetComponent<Animator>().SetTrigger("bottle1");

	}

	public void straws()
	{
		//the name of the trigger to happen when button is pressed in the animator
		GameObject.Find("Straw1").GetComponent<Animator>().SetTrigger("straw1");
		GameObject.Find("Straw2").GetComponent<Animator>().SetTrigger("straw2");

	}
		
	public void crates()
	{
		//the name of the trigger to happen when button is pressed in the animator
		GameObject.Find("Crate1").GetComponent<Animator>().SetTrigger("crate1");
		GameObject.Find("Crate2").GetComponent<Animator>().SetTrigger("crate2");

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
