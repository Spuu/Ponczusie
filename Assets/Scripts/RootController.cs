using UnityEngine;
using System.Collections;

public class RootController : MonoBehaviour {
	public GameObject CreationObject;
	public float LeftArm = 0;
	public float RightArm = 90;
	public float CreationTime = 1;
	public float Force = 200;
	
	private float LastCreationTime;

	// Use this for initialization
	void Start () {
		LastCreationTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - LastCreationTime > CreationTime) {
			Debug.Log ("Brick Generation");
			
			Vector3 shootVec = new Vector3(0,0,Random.Range(LeftArm, RightArm));
			Debug.Log(shootVec);
			
			GameObject go = Instantiate(CreationObject) as GameObject;
			go.transform.position = this.transform.position;
			go.transform.Rotate(shootVec);
			go.rigidbody2D.AddRelativeForce(Vector3.up * Force * go.rigidbody2D.mass);
			go.rigidbody2D.mass = Random.Range(1,3);
			LastCreationTime = Time.time;
		}
	}
}
