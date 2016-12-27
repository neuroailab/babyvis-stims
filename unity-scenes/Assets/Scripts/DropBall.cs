using UnityEngine;
using System.Collections;

public class DropBall : MonoBehaviour {

	private Vector3 init_pos;
	// Use this for initialization
	void Start () {
		init_pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("b")) 
		{
			Debug.Log("ball dropping");
			GetComponent<Rigidbody>().useGravity = true;
		}
		if(Input.GetKeyDown("r"))
		{
			Debug.Log("ball reset");
			GetComponent<Rigidbody>().useGravity = false;
			transform.position = init_pos;
		}
	}
}
