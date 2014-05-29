using UnityEngine;
using System.Collections;

public class PlayerController2 : MonoBehaviour {
	
	private float distance = 3f;
	private float rottingdistance = 30f;
	private float kihirmirglhil;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if ( Input.GetAxis ("Vertical2")!=0){
			transform.position = new Vector3 ( transform.position.x, transform.position.y+Input.GetAxis("Vertical2") * -distance * Time.deltaTime, transform.position.z );
		}
		if ( Input.GetAxis("Horizontal2") != 0 ){
			transform.position = new Vector3 ( transform.position.x + Input.GetAxis("Horizontal2") * distance * Time.deltaTime, transform.position.y, transform.position.z );
			kihirmirglhil=-Input.GetAxis("Horizontal2")/Mathf.Abs(Input.GetAxis("Horizontal2"));
			if ( transform.eulerAngles.z<90 || transform.eulerAngles.z>270)
				transform.Rotate(0, 0, 90*kihirmirglhil);
		}
	}
}
