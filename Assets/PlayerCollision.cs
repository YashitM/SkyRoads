using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	// Use this for initialization
	// void Start () {
		
	// }
	
	// Update is called once per frame
	// void Update () {
		
	// }
	public Rigidbody rb;
	public PlayerMovement movement;
	public float health = 100f;

	void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.collider.tag=="Obstacle")
		{
			health = health - 34;
			Debug.Log(health);
			Collider.Destroy(collisionInfo.collider);
			if(health>0)
			{

			}
			else
			{
				movement.enabled = false;
			}
		}
	}
}
