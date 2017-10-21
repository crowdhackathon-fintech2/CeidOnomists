using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target; //what camera is following
    public float smoothing; //dampening effect

    Vector3 offset;
    Vector3 lastTargetPos;
    float lowY;


    //Ceid
    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.position;

        lowY = transform.position.y - 5;
    }


    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 targetCamPos = target.position + offset;
            lastTargetPos = target.position + offset;

            transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

            if (transform.position.y < lowY) transform.position = new Vector3(transform.position.x, lowY, transform.position.z);
        }
        else transform.position = new Vector3(lastTargetPos.x, lastTargetPos.y, lastTargetPos.z);
    }
}
