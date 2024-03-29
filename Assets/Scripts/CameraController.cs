﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 _offset;

	// Use this for initialization
	void Start () {
		_offset = transform.position;
	}
	
	// Use LateUpdate for camera
	void LateUpdate () {	
		transform.position = player.transform.position + _offset;
	}
}
