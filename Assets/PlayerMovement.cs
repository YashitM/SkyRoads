using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody spaceShipBody;
	public float forwardSpeed = 1.0f;

	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		spaceShipBody = GetComponent<Rigidbody>();
	}

	public float g=9.8f;

    void FixedUpdate() {
        var gravity = new Vector3(Input.acceleration.x * 2.5f, 0, forwardSpeed)*g;

        spaceShipBody.AddForce (gravity);
    }
}
