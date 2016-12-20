using UnityEngine;
using System.Collections;

public class RevealBox : MonoBehaviour {

	private bool isRevealed;
	// Use this for initialization
	void Start () {
		isRevealed = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			if(isRevealed)
			{
		 		this.GetComponent<MeshRenderer>().enabled = false;
				isRevealed = false;
		 	}
		 	else
		 	{
				this.GetComponent<MeshRenderer>().enabled = true;
				isRevealed = true;
		 	}
		}
	}
}
