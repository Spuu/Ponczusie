using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speedH = 15000;
	public float decay = 10;

	float isRight = 1.0f;
	
	// Use this for initialization
	void Start () {
	}
	
	void Update () {
		bool jump = Input.GetButtonDown("Jump");
		
		// touch
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
			jump = true;
		
		if(jump) {
			isRight *= -1.0f;
		}
		
		float alfa = 1.0f;
		if( Time.time < decay ) {
			alfa = Time.time / decay;
		}
		
		rigidbody2D.AddForce(isRight * speedH * Time.deltaTime * Vector2.right * Mathf.Lerp(0, 1, alfa));
		
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit();
	}
	// Update is called once per frame
	/*void Update () {
		bool jump = Input.GetButtonDown("Jump");
		
		// keyboard
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
		rigidbody2D.AddForce(move * speedH * Time.deltaTime);
		
		// touch
		if (Input.touchCount > 0) {
			switch(Input.GetTouch(0).phase) {
				case TouchPhase.Moved:
					Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
					rigidbody2D.AddForce(touchDeltaPosition * 100);
					break;
				
				case TouchPhase.Began:
					startTap = Time.time;
					break;
					
				case TouchPhase.Ended:
					endTap = Time.time;
					break;
			}
					
			if( endTap - startTap < diffTap ) {
				//jump = true;
			}
		} else {
			jump = false;
		}
		
		if(jump) {
			rigidbody2D.AddForce(Vector3.up * speedV);
			jump = false;
		}
		
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit();
	}*/
}
