using UnityEngine;
using System.Collections;

public class PlayerController3 : MonoBehaviour {
	
	private float distance = 3f;
	private float rottingdistance = 60f;
	private float rot;
	private float y;
	private float x;

	float anglePrev = 0f;
	float angleNext = 0f;
	float rotationDegRelative = 0f;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		y = Input.GetAxis("Vertical3");
		x = Input.GetAxis("Horizontal3");



		//movement
		if ( y!=0 ){
			transform.position = new Vector3 ( transform.position.x, transform.position.y+ y * -distance * Time.deltaTime, transform.position.z );
		}
		if ( x!=0 ){
			transform.position = new Vector3 ( transform.position.x + x * distance * Time.deltaTime, transform.position.y, transform.position.z );
		}

//		//rotation
		angleNext = Mathf.Atan2(y,x) * Mathf.Rad2Deg;
		//Debug.Log (transform.eulerAngles + ", (" + x + ", " + y + "), " + angleNext);
		//Debug.Log (angleNext);
		if ( angleNext < 0 ) angleNext += 360;
		rotationDegRelative = angleNext - anglePrev;
		transform.Rotate(0,0,rotationDegRelative);
		anglePrev = angleNext;
		
//			float rot=-Input.GetAxis("Horizontal3")/Mathf.Abs(Input.GetAxis("Horizontal3"));
//			if ( transform.eulerAngles.z<90 || transform.eulerAngles.z>270)
//				transform.Rotate(0, 0, 90*rot);
//		}
	}
}
