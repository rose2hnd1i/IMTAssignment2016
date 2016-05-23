using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private Vector3 offset;
	public Transform TRTL_B;


	// Use this for initialization
	void Awake () {
		offset = transform.position - TRTL_B.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = TRTL_B.position + offset;
	}
}
