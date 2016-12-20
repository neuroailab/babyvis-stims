using UnityEngine;
using System.Collections;

public class MoveStick : MonoBehaviour {

	public float min = 0.05f;
	public float max = 0.05f;
	// Use this for initialization
	void Start () {
		min=transform.position.x - 0.05f;
        max=transform.position.x + 0.05f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position =new Vector3(Mathf.PingPong(Time.time/10,max-min)+min, transform.position.y, transform.position.z);
	}
}