using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	// Use this for initialization
	// void Start () {
		
	// }
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0,0,2000*Time.deltaTime);
	}
}
