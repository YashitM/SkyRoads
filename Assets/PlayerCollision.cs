using UnityEngine;

public class PlayerCollision : MonoBehaviour {

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
			if(health<=0)
			{
				movement.enabled = false;
			}
		}
	}
}
