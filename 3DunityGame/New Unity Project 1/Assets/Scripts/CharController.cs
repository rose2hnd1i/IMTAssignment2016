using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharController : MonoBehaviour {

	//sound
	public AudioClip fishClip;
	private AudioSource audioSource;

	public Text scoreText;
	public Text livesText;

	//sounds
	//public AudioClip troutFish;
	//var fishClip:AudioClip;
	//public AudioClip fishClip;

	//private Rigidbody rigbdy;



	int score1;
	//set number of lives
	public int lives;
	public GUISkin skin;



	// Use this for initialization
	void Start () {


	}

	//sound
	void Awake(){
		audioSource = GetComponent <AudioSource> ();
	}

	void OnTriggerEnter(Collider otherObject)
	{
		// positive +
		if (otherObject.tag == "s5") {
			//Debug.Log ("touched");
			score1+=1;
			Destroy (otherObject.gameObject);
		}
		if (otherObject.tag == "s6") {
			score1+=1;
			Destroy (otherObject.gameObject);
		}
		if (otherObject.tag == "s3") {
			score1+=1;
			Destroy (otherObject.gameObject);
		}

		if (otherObject.tag == "s1") {
			score1+=1;
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
			score1 += 20;
			transform.localScale += new Vector3 (10f, 10f, 10f);

			//sound
			audioSource.clip = fishClip;
			audioSource.Play ();
			Debug.Log ("fish sound trigger");
			Destroy (otherObject.gameObject);
		}

		if (otherObject.tag == "coin") {
			transform.localScale += new Vector3 (-10f, -10f, -10f);
			score1 += 14;
			Debug.Log ("coin collected");
			Destroy (otherObject.gameObject);
		}

		if (otherObject.tag == "aid") {
			transform.localScale += new Vector3 (-20f, -20f, -20f);
			lives++;
			Destroy (otherObject.gameObject);
		}

		scoreText.text = "Score: " + score1 + "/15";
		livesText.text = "Lives: " + lives;

	}




	// Update is called once per frame
	void Update () {


		if (score1 == 15)
			//when the player reaches points wins

		{
			//go to win level
			Application.LoadLevel("win");
		}

		if (lives == 0) 
		{
			Application.LoadLevel ("lose");
		}

	
		//public void bottles()
		//{
			//the name of the trigger to happen when button is pressed in the animator 
		//	GameObject.Find("bottle").GetComponent <Animator>().SetTrigger ("bottles");

		//}

	}

}


