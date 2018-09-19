using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMetrics : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate () {
		Rigidbody rb = this.GetComponent<Rigidbody> ();
		if(!Mathf.Approximately(rb.velocity.x,0.0f))
		{
			Debug.Log ("Velocity X: " + rb.velocity.x);		
		}

	}
}
