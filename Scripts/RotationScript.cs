using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {


    Quaternion theRotation;
    // Use this for initialization.
    void Start () {
        theRotation = transform.localRotation;

		theRotation.x = Camera.main.transform.localRotation.x;

		transform.localRotation = theRotation;


    }



}
