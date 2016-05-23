using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour {



	//code which is triggered when the next button is pressed
	public void easy()
	{
		SceneManager.LoadScene ("lvl1");
	}
	public void medium()
	{
		SceneManager.LoadScene ("scene3");
	}
	public void hard()
	{
		SceneManager.LoadScene ("scene1");
	}
	public void Instructions()
	{
		SceneManager.LoadScene ("instructions");
	}



	//code which is triggered when the preious button is pressed
	public void leftkey()
	{
		SceneManager.LoadScene ("scene1");
	}
	//code which is triggered when the preious button is pressed
	public void upkey()
	{
		SceneManager.LoadScene ("scene3");
	}
	public void rightkey()
	{
		SceneManager.LoadScene ("scene3");
	}
	public void downkey()
	{
		SceneManager.LoadScene ("scene3");
	}


	public void menu()
	{
		SceneManager.LoadScene ("menu");
	}
		


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


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
