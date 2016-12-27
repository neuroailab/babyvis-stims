using UnityEngine;
using System.Collections;

public class MoveScreen : MonoBehaviour {

	public float speed = 1.0F;
	private Vector3 down;
	private Vector3 up;
	private float startTime;
	private float distance;

	private bool isUp = true;

	// Use this for initialization
	void Start () {
		down = transform.position;
		up = transform.position;
		up.y = up.y + 1f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire2")) 
		{
			if(isUp)
			{
				Debug.Log("screen up");
				startTime = Time.time;
				distance = Vector3.Distance(up, down);
				isUp = false;
			}
			else
			{
				Debug.Log("screen down");
				startTime = Time.time;
				distance = Vector3.Distance(down, up);
				isUp = true;
			}
		}

		if(distance != 0)
		{
			float fracDistance = ((Time.time - startTime) * speed) / distance;
			if(isUp)
				transform.position = Vector3.Lerp(up, down, fracDistance);	
			else
				transform.position = Vector3.Lerp(down, up, fracDistance);
		}
	}
}
