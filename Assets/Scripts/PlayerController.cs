using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speedH = 15000;
	public float speedV = 1000;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
		rigidbody.AddForce(move * speedH * Time.deltaTime);
		
		if(Input.GetButtonDown("Jump")) {
			rigidbody.AddForce(Vector3.up * speedV);
		}
	}
}
