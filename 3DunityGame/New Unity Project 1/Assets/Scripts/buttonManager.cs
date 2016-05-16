using UnityEngine;
using System.Collections;

public class buttonManager : MonoBehaviour {


	//code which is triggered when the next button is pressed
	public void easy()
	{
		Application.LoadLevel ("lvl1");
	}
	public void medium()
	{
		Application.LoadLevel ("scene3");
	}
	public void hard()
	{
		Application.LoadLevel ("scene1");
	}
	public void Instructions()
	{
		Application.LoadLevel ("instructions");
	}



	//code which is triggered when the preious button is pressed
	public void leftkey()
	{
		Application.LoadLevel ("scene1");
	}
	//code which is triggered when the preious button is pressed
	public void upkey()
	{
		Application.LoadLevel ("scene3");
	}
	public void rightkey()
	{
		Application.LoadLevel ("scene3");
	}
	public void downkey()
	{
		Application.LoadLevel ("scene3");
	}


	public void menu()
	{
		Application.LoadLevel ("menu");
	}

	//public void forwardWalk()
	//{
		// The current move direction in x-z
		//private var moveDirection = Vector3.zero;
		// The current vertical speed
		//private var verticalSpeed = 0.0;
		// The current x-z move speed
		//private var moveSpeed = 0.0;
	//moveDirection = transform.TransformDirection (Vector3.forward);
	//}


	//code which is triggered when the fade button is pressed
	//public void fadeButtonPressed()
	//{

	//	GameObject.Find ("Smiley").GetComponent<Animator> ().SetTrigger ("enableFade");

	//}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
