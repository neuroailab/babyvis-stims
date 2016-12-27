using UnityEngine;
using System.Collections;

public class MoveFirstBear : MonoBehaviour {

	public float speed = 1.0F;
	private Vector3 down;
	private Vector3 up;
	private Vector3 left;
	private Vector3 right;
	private float startTime;
	private float distance;

	private bool isUp = false;
	private bool isDown = false;
	private bool isLeft = false;
	private bool isRight = false;

	// Use this for initialization
	void Start () {
		down = transform.position;
		up = transform.position;
		right = transform.position;
		left = transform.position;
		down.y = down.y - 1f;
		left.x = left.x - 1.2f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("a")) 
		{
			Debug.Log("bear left");
			startTime = Time.time;
			distance = Vector3.Distance(right, left);
			isLeft = true;
			isDown = false;
			isUp = false;
			isRight = false;
		}
		if(Input.GetKeyDown("d")) 
		{
			Debug.Log("bear right");
			startTime = Time.time;
			distance = Vector3.Distance(left, right);
			isLeft = false;
			isDown = false;
			isUp = false;
			isRight = true;
		}
		if(Input.GetKeyDown("s")) 
		{
			Debug.Log("bear down");
			startTime = Time.time;
			distance = Vector3.Distance(up, down);
			isLeft = false;
			isDown = true;
			isUp = false;
			isRight = false;
		}
		if(Input.GetKeyDown("w")) 
		{
			Debug.Log("bear up");
			startTime = Time.time;
			distance = Vector3.Distance(down, up);
			isLeft = false;
			isDown = false;
			isUp = true;
			isRight = false;
		}

		if(distance != 0)
		{
			float fracDistance = ((Time.time - startTime) * speed) / distance;
			if(isLeft) {
				left.y = transform.position.y;
				right.y = left.y;
				transform.position = Vector3.Lerp(right, left, fracDistance);
			}	
			if(isRight) {
				left.y = transform.position.y;
				right.y = left.y;
				transform.position = Vector3.Lerp(left, right, fracDistance);
			}
			if(isDown) {
				up.x = transform.position.x;
				down.x = up.x;
				transform.position = Vector3.Lerp(up, down, fracDistance);
			}
			if(isUp) {
				up.x = transform.position.x;
				down.x = up.x;
				transform.position = Vector3.Lerp(down, up, fracDistance);
			}
		}
	}
}
