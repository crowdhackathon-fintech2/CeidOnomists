using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roulete : MonoBehaviour {

	public GameObject gO;
	// Use this for initialization.
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		HingeJoint hinge = gO.GetComponent<HingeJoint>();
		JointMotor motor = hinge.motor;
		motor.force = 100;
	}
}
