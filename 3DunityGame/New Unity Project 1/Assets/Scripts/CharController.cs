using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

	int score1;
	//set number of lives
	public int lives;
	public GUISkin skin;



	// Use this for initialization
	void Start () {


	}

	void OnGUI()
	{
		GUI.skin = skin;
		GUI.color = Color.black;
		GUI.Label (new Rect(0,0,150,30),"LEVEL 1 "); 
		GUI.Label (new Rect(0,20,150,30),"Score : "+score1+ "/15 ");
		GUI.Label (new Rect(0,40,150,30),"Lives : "+lives);

	}

	void OnTriggerEnter(Collider otherObject)
	{
		// positive +
		if (otherObject.tag == "s5") {
			Debug.Log ("touched");
			score1++;
			Destroy (otherObject.gameObject);
		}
		if (otherObject.tag == "s6") {
			score1++;
			Destroy (otherObject.gameObject);
		}
		if (otherObject.tag == "s3") {
			score1++;
			Destroy (otherObject.gameObject);
		}

		if (otherObject.tag == "s1") {
			score1++;
			Destroy (otherObject.gameObject);
		}

		//negative -

		if (otherObject.tag == "straw") {
			lives--;
			Destroy (otherObject.gameObject);
		}
		
		if (otherObject.tag == "bottle") {
			lives--;
			Destroy (otherObject.gameObject);
		}


		//3 player modifiers 

		if (otherObject.tag == "trout") {
			//GetComponent <Animator>().SetTrigger ("turtle2");
			transform.localScale += new Vector3 (10f, 10f, 10f);
			score1 += 2;
			Destroy (otherObject.gameObject);
		}

		if (otherObject.tag == "coin") {
			transform.localScale += new Vector3 (-10f, -10f, -10f);
			score1 += 5;
			Destroy (otherObject.gameObject);
		}

		if (otherObject.tag == "aid") {
			transform.localScale += new Vector3 (-20f, -20f, -20f);
			lives++;
			Destroy (otherObject.gameObject);
		}
		//if (otherObject.tag == "aid") {
		//	transform.localScale += new Vector3 (5f, 0, 0);
		//}
	}




	// Update is called once per frame
	void Update () {


		if (score1 == 15)
			//when the player reaches 20points wins

		{
			//go to win level
			Application.LoadLevel("win");
		}

		if (lives == 0) 
		{
			Application.LoadLevel ("lose");
		}

	
		if (Input.GetKeyDown (KeyCode.L)) {
			//the name of the trigger to happen when L is pressed in the animator inside the stick figure
			GetComponent <Animator>().SetTrigger ("flyT");
		}

	}
}


