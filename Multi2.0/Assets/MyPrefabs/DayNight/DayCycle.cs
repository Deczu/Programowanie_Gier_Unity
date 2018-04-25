﻿using UnityEngine;
using System.Collections;

public class DayCycle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.right, 1f * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }
}
