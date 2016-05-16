
var myAnimation : Animator;

function Update()
{
	if (Input.GetKeyUp ("1"))
		myAnimation.SetBool("bottleFloat", true);

	if (Input.GetKeyUp ("2"))
		myAnimation.SetBool("bottleFloat", false);

}
