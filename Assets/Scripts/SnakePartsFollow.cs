using UnityEngine;
using System.Collections;

public class SnakePartsFollow : MonoBehaviour {

	public Transform head;
	public Transform body;
	public Transform tail;

	// Use this for initialization
	void Start () {
		//head = transform;
	}
	
	// Update is called once per frame
	void Update () {


		/*
		Vector3 deadzone = new Vector3( 2,2,2 );
		Vector3 diffToHead = body.Find("pivotFront").position - head.Find("pivot").position; 
		//Debug.Log ( Mathf.Abs(diffToHead.x) + ", " + Mathf.Abs(diffToHead.y) + ", " + Mathf.Abs(diffToHead.z) );
		if ( Mathf.Abs(diffToHead.x) > deadzone.x || Mathf.Abs(diffToHead.y) > deadzone.y ) body.position -= diffToHead/5;

		//determine angle to head
		//SOHCAHTOA..
		//theta = arctan ( opp/adj ) 

		float x = diffToHead.x;
		float y = diffToHead.y;
		float angleNext = 0f;

		if (x!=0 && y !=0) angleNext = Mathf.Atan2(x,-y) * Mathf.Rad2Deg;
		//Debug.Log ( y + ", " + x + ", " + angleNext );
		body.eulerAngles = new Vector3(body.eulerAngles.x ,body.eulerAngles.y, angleNext);
		*/






	
	}
}

//public static implicit bool operator 
