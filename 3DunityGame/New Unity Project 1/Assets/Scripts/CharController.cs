using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CharController : MonoBehaviour {

	//sound
	public AudioClip fishClip;
	public AudioClip coinClip;
	public AudioClip healthClip;
	public AudioClip bottleClip;
	public AudioClip strawClip;
	//

	private AudioSource audioSource;

	public Text scoreText;
	public Text livesText;

	//sounds
	//public AudioClip troutFish;
	//var fishClip:AudioClip;
	//public AudioClip fishClip;

	//private Rigidbody rigbdy;



	int score;
	public int maxScore;
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
		if (otherObject.tag == "good") {
			score+=1;
			Destroy (otherObject.gameObject);
		}

		//negative -

		if (otherObject.tag == "straw") {
			lives--;
			audioSource.clip = strawClip;
			audioSource.Play ();
			Destroy (otherObject.gameObject);
		}
		
		if (otherObject.tag == "bottle") {
			lives--;
			//
			audioSource.clip = bottleClip;
			audioSource.Play ();
			//
			Destroy (otherObject.gameObject);
		}


		//3 player modifiers 

		if (otherObject.tag == "trout") {
			score += 2;
			transform.localScale += new Vector3 (10f, 10f, 10f);

			//sound
			audioSource.clip = fishClip;
			audioSource.Play ();
			Debug.Log ("fish sound trigger");

			Destroy (otherObject.gameObject);
		}

		if (otherObject.tag == "coin") {
			transform.localScale += new Vector3 (-10f, -10f, -10f);
			score += 5;
			audioSource.clip = coinClip;
			audioSource.Play ();

			Debug.Log ("coin collected");
			Destroy (otherObject.gameObject);
		}

		if (otherObject.tag == "aid") {
			transform.localScale += new Vector3 (-20f, -20f, -20f);
			lives++;

			audioSource.clip = healthClip;
			audioSource.Play ();

			Destroy (otherObject.gameObject);
		}

		scoreText.text = "Score: " + score + "/" + maxScore;
		livesText.text = "Lives: " + lives;

		if (score >= maxScore)
			//when the player reaches points wins

		{
			//go to win level
			SceneManager.LoadScene("win");

		}

		if (lives == 0) 
		{
			SceneManager.LoadScene("lose");

		}

	}

}


