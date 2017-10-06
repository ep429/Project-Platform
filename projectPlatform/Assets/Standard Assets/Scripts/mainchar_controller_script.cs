using UnityEngine;
using System.Collections;

public class mainchar_controller_script : MonoBehaviour {

	public float maxSpeed = 7f;
	bool facingRight = true;

	Animator anim;
	
	float groundRadius = 0.2f;
	public float jumpForce = 350f;
	bool grounded = false;
	bool canDoubleJump = true;
	public Transform groundCheck;
	public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);
		anim.SetBool ("DoubleJump", canDoubleJump);
		anim.SetFloat ("vspeed", GetComponent<Rigidbody2D>().velocity.y);


		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat ("speed", Mathf.Abs(move));

		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
	
		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}

	void Update()
	{
		if (grounded)
			canDoubleJump = true;
		if(grounded && Input.GetKeyDown(KeyCode.Space))
		{
			anim.SetBool("Ground", false);
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
		}
		if (!grounded && canDoubleJump && Input.GetKeyDown (KeyCode.Space))
		{
			canDoubleJump = false;
			anim.SetBool ("DoubleJump", false);
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpForce));
		}
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}