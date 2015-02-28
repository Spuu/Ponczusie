using UnityEngine;
using System.Collections;

public class FloorAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision c) {
		if( c.transform.tag == "Brick" )
			Destroy(c.gameObject);
	}
}
