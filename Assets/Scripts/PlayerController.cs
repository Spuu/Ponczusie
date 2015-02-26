using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 3000;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
		rigidbody.AddForce(move * speed * Time.deltaTime);
	}
}
