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
		GUI.color = Color.green;
		GUI.Label (new Rect(0,0,150,30),"LEVEL 1 "); 
		GUI.Label (new Rect(0,20,150,30),"Score : "+score1+ "/15 ");
		GUI.Label (new Rect(0,40,150,30),"Lives : "+lives);

	}

	void OnTriggerEnter(Collider otherObject)
	{
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

		if (otherObject.tag == "trout") {
			score1+=10;
			Destroy (otherObject.gameObject);
		}

		if (otherObject.tag == "straw") {
			lives--;
			Destroy (otherObject.gameObject);
		}
		
		if (otherObject.tag == "bottle") {
			lives--;
			Destroy (otherObject.gameObject);
		}

		if (otherObject.tag == "coin") {
			lives++;
			Destroy (otherObject.gameObject);
		}

	}




	// Update is called once per frame
	void Update () {


		if (score1 == 15)
			//when the player reaches 15points wins


		{
			//go to win level
			Application.LoadLevel("win");
		}

		if (lives == 0) 
		{
			Application.LoadLevel ("lose");
		}



	}
}


