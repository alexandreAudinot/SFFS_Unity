using UnityEngine;
using System.Collections;

public class ProjectileSpawner : MonoBehaviour {

    public GameObject prefab;
    public float porjectileSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject o = GameObject.Instantiate(prefab);
            o.transform.position = transform.position;
            o.transform.rotation = transform.rotation;
            Rigidbody body = o.GetComponent<Rigidbody>();
            body.AddRelativeForce(0f, 0f, porjectileSpeed, ForceMode.Impulse);
        }	
	}
}
