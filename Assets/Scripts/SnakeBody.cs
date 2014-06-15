using UnityEngine;
using System.Collections;

public class SnakeBody : MonoBehaviour {

	private float moveSpeed = 5f;
	private float rotationSpeed = 10f;
	private Transform target;
	private Transform source;

	// Use this for initialization
	void Start () {
		source = transform.FindChild ("pivotFront");
		target = transform.parent.GetComponent<SnakePartsFollow>().head.FindChild("pivot").transform;
	}
	
	// Update is called once per frame
	void Update () {

		//rotate to look at the player
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - source.position), rotationSpeed*Time.deltaTime);
		
		//move towards the player
		transform.position += transform.forward * moveSpeed * Time.deltaTime;
		

	}
}
