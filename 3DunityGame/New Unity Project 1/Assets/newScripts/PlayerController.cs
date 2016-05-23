using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    public float horizontal = 0f;
    public float vertical = 0f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movementKeyboard = new Vector3(moveHorizontal, 0f, moveVertical);

        Vector3 movementTouch = new Vector3(horizontal, 0f, vertical);

		rb.MovePosition(transform.position + (movementKeyboard * speed * Time.deltaTime));
		rb.MovePosition(transform.position + (movementTouch * speed * Time.deltaTime));

		ChangeRotation ();
    }

	void ChangeRotation ()
	{

		if (horizontal == -1f) {
			rb.MoveRotation (Quaternion.Euler (0f, 270f, 0f));
		}
		else if (horizontal == 1f) {
			rb.MoveRotation (Quaternion.Euler (0, 90f, 0f));
		}

		else if (vertical == -1f) {
			rb.MoveRotation (Quaternion.Euler (0, 180f, 0f));
		}

		else if (vertical == 1f) {
			rb.MoveRotation (Quaternion.Euler (0, 360f, 0f));
		}
	}
}