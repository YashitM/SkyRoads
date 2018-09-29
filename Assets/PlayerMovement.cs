using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody spaceShipBody;
	public float forwardSpeed = 20.0f;

	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		spaceShipBody = GetComponent<Rigidbody>();
	}

	public float g=9.8f;

    void FixedUpdate() {
        var gravity = new Vector3(Input.acceleration.x * 15.0f, 0, 0)*g;
		var curr_pos = GameObject.Find("Player").transform.position;
		var curr_x = curr_pos.x;
		var curr_y = curr_pos.y;
		
		var angleBoardRotX = Mathf.Atan(curr_y/curr_x)*100;
		Debug.Log(angleBoardRotX);

		transform.Rotate(new Vector3(0,0,angleBoardRotX) * Time.deltaTime);

        spaceShipBody.AddForce (gravity);
    }
}
