using UnityEngine;
using System.Collections;

public class TimeOutScript : MonoBehaviour {

    public float lifetime = 5;

    private float life;

	// Use this for initialization
	void Start () {
        life = lifetime;
	}
	
	// Update is called once per frame
	void Update () {
        life -= Time.deltaTime;
        if (life < 0)
            Destroy(this.gameObject);
	}
}
