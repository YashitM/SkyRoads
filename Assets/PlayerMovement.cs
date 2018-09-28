using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	// Use this for initialization
	// void Start () {
		
	// }
	public float forwardForce = 2000f;
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0,0,forwardForce*Time.deltaTime);
	}
}
