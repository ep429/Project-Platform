using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float interpVelocity;
	public float minDistance;
	public float followDistance;
	public float minimum = 0.0f;
	public float maximum = 0.0f;
	public float rangeX;
	public float rangeY;
	public GameObject target;
	public Vector3 offset;
	Vector3 targetPos;
	// Use this for initialization
	void Start () {
		targetPos = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (target)
		{
			Vector3 posNoZ = transform.position;
			posNoZ.z = target.transform.position.z;
			
			Vector3 targetDirection = (target.transform.position - posNoZ);
			
			interpVelocity = targetDirection.magnitude * 7f;
			
			targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime); 
			
			transform.position = Vector3.Lerp( transform.position, targetPos + offset, 0.25f);
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, -(rangeX/2), (rangeX/2)), Mathf.Clamp(transform.position.y, -(rangeY/2), (rangeY/2)), -6);
		}

	}
}
