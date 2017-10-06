using UnityEngine;
using System.Collections;

public class RightMove : MonoBehaviour {

	
	public float speed = 3f;
	
	private float startingPositionX;
	public float endingPositionX = 5f;
	private float distance;
	private float originalDistance;
	private float originalPositionX;
	
	
	
	void Start(){
		startingPositionX = transform.position.x;
		distance = endingPositionX - startingPositionX;
		originalDistance = endingPositionX - startingPositionX;
		originalPositionX = transform.position.x;
	}
	
	
	void FixedUpdate(){
		GetComponent<Rigidbody2D>().velocity = new Vector2 (speed, GetComponent<Rigidbody2D>().velocity.y);
		distance = endingPositionX - transform.position.x;
		print (distance);
		
	}
}
