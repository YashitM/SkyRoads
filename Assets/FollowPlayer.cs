﻿using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	// Use this for initialization
	// void Start () {
		
	// }
	public Transform player;
	public Vector3 offset;
	// Update is called once per frame
	void Update () {
		transform.position = player.position + offset;
	}
}
