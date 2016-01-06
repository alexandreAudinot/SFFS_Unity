using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {
	public float speed = 3f;
	public float reverseSpeed = 1f;
	public float rotationSpeed = 3f;
	private Rigidbody body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Z))
		{
			body.AddRelativeForce(0f, 0f, speed, ForceMode.Impulse);
		}
		if(Input.GetKey(KeyCode.S))
		{
			body.AddRelativeForce(0f, 0f, -reverseSpeed, ForceMode.Impulse);
		}
		if(Input.GetKey(KeyCode.Q))
		{
			body.AddRelativeTorque(0f, -rotationSpeed, 0f);
		}
		if(Input.GetKey(KeyCode.D))
		{
			body.AddRelativeTorque(0f, rotationSpeed, 0f);
		}
	}
}
