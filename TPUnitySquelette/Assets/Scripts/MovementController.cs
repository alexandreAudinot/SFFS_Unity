using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {
	
	private Rigidbody body;
	// TODO

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Movement
		if(Input.GetKey(KeyCode.Z))
		{
			// TODO
		}
		if(Input.GetKey(KeyCode.S))
		{
			// TODO
		}
		// Rotations
		if(Input.GetKey(KeyCode.Q))
		{
			// TODO
		}
		if(Input.GetKey(KeyCode.D))
		{
			// TODO
		}
	}
}
