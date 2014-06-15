using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public Players player;
	
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
	
	
	// Update is called once per frame
	void Update () {
		
		//accepts overriding input of both keyboard and joysticks for same player. laziest implementation possible.
		//also note most keyboards cannot handle >2 players due to their limited key cache size
		
		x = Input.GetAxis(player.ToString() + "kx");
		y = Input.GetAxis(player.ToString() + "ky");
		Motion();
		
		
		x = Input.GetAxis(player.ToString() + "x");
		y = Input.GetAxis(player.ToString() + "y");
		Motion();
		
		
	}
	
	void Motion(){
		
		//movement
		if (  x!=0 || y!=0 ){
			transform.position = new Vector3 ( transform.position.x + x * distance * Time.deltaTime, transform.position.y+ y * -distance * Time.deltaTime, transform.position.z );
		}
		
		//rotation
		if (x!=0 && y !=0) angleNext = Mathf.Atan2(-x,-y) * Mathf.Rad2Deg;
		transform.eulerAngles = new Vector3(transform.eulerAngles.x ,transform.eulerAngles.y, angleNext);
		
	}
}
