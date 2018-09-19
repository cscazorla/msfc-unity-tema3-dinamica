using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuffleboard : MonoBehaviour {

	public Vector3 initialSpeed = new Vector3(8.5f,0,0);

	// Use this for initialization
	void Start () {
		Rigidbody rb = this.GetComponent<Rigidbody> ();

		rb.velocity = initialSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
