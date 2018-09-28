using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	// Use this for initialization
	// void Start () {
		
	// }
	public float forwardForce = 2000f;
	public float sideWaysForce = 500f;
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0,0,forwardForce*Time.deltaTime);

		if(Input.GetKey("d"))
		{
			rb.AddForce(sideWaysForce*Time.deltaTime,0,0);
		}
		if(Input.GetKey("a"))
		{
			rb.AddForce(-1*sideWaysForce*Time.deltaTime,0,0);
		}

	}
}
