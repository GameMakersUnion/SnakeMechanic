using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public Players playerNum;
	
	private float distance = 3f;
	private float y;
	private float x;
	
	float anglePrev = 0f;
	float angleNext = 0f;
	float rotationDegRelative = 0f;

	public enum Players{
		Player1,
		Player2,
		Player3,
		Player4
	}
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		x = Input.GetAxis(playerNum.ToString() + "x");
		y = Input.GetAxis(playerNum.ToString() + "y");

		//movement
		if (  x!=0 || y!=0 ){
			transform.position = new Vector3 ( transform.position.x + x * distance * Time.deltaTime, transform.position.y+ y * -distance * Time.deltaTime, transform.position.z );
		}
		
		//rotation
		if (x!=0 && y !=0) angleNext = Mathf.Atan2(-x,-y) * Mathf.Rad2Deg;
		transform.eulerAngles = new Vector3(transform.eulerAngles.x ,transform.eulerAngles.y, angleNext);

	}
}
