using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target; //what camera is following
    //public float smoothing; //dampening effect

    Vector3 offset;
    Vector3 lastTargetPos;
    float lowY;

    int levelCount = EconomicManagerScirpt.LoadedScenesCount;
    Vector3 camPosition;

    private void Start()
    {
        if (levelCount == 0)
        {
            offset = new Vector3(transform.position.x - target.position.x, 0f, transform.position.z - target.position.z);
        }
        else
        {
            offset = new Vector3(PlayerPrefs.GetFloat("CameraX") - PlayerPrefs.GetFloat("X"), 0f, PlayerPrefs.GetFloat("CameraZ") - PlayerPrefs.GetFloat("CameraZ"));
        }
        print(levelCount);
    }

    private void Update()
    {
        if (levelCount == 0)
        {
            Vector3 camPosition = new Vector3(target.position.x, transform.position.y, target.position.z);
            transform.position = camPosition + offset;
        }

        else
        {
            Vector3 camPosition = new Vector3(PlayerPrefs.GetFloat("X"), transform.position.y, PlayerPrefs.GetFloat("Z"));
            transform.position = camPosition + offset;
        }


    }


    private void OnDisable()
    {
        PlayerPrefs.SetFloat("CameraX", transform.transform.position.x);
        PlayerPrefs.SetFloat("CameraY", transform.transform.position.y);
        PlayerPrefs.SetFloat("CameraZ", transform.transform.position.z);


    }





}

//    void Start()
//    {
        
//        offset = transform.position - target.position;

//        lowY = transform.position.y - 5;
//    }

//    private void OnDisable()
//    {
//        PlayerPrefs.SetFloat("offsetX", transform.position.x - target.position.x);
//        PlayerPrefs.SetFloat("offsetY", transform.position.y - target.position.y);
//        PlayerPrefs.SetFloat("offsetZ", transform.position.z - target.position.z);

        
//    }

//    private void OnEnable()
//    {
//        if (PlayerPrefs.GetFloat("offsetX") != 0.0f && PlayerPrefs.GetFloat("offsetY") != 0.0f && PlayerPrefs.GetFloat("offsetZ") != 0.0f)
//        {
//            SavedOffset = new Vector3(PlayerPrefs.GetFloat("offsetX"), PlayerPrefs.GetFloat("offsetY"), PlayerPrefs.GetFloat("offsetZ"));
//            targetCamPos = target.position + SavedOffset;
//            lastTargetPos = target.position + SavedOffset;
//        }
//        transform.position = new Vector3(lastTargetPos.x, lastTargetPos.y, lastTargetPos.z);
//    }

//    void FixedUpdate()
//    {
        
//        if (target != null)
//        {
//            if (PlayerPrefs.GetFloat("offsetX") != 0.0f && PlayerPrefs.GetFloat("offsetY") != 0.0f && PlayerPrefs.GetFloat("offsetZ") != 0.0f)
//            {
//                SavedOffset = new Vector3(PlayerPrefs.GetFloat("offsetX"), PlayerPrefs.GetFloat("offsetY"), PlayerPrefs.GetFloat("offsetZ"));
//                targetCamPos = target.position + SavedOffset;
//                lastTargetPos = target.position + SavedOffset;
//            }
//            else
//            {
//                targetCamPos = target.position + offset;
//                lastTargetPos = target.position + offset;
//            }
            

//            transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

//            if (transform.position.y < lowY) transform.position = new Vector3(transform.position.x, lowY, transform.position.z);
//        }
//        else transform.position = new Vector3(lastTargetPos.x, lastTargetPos.y, lastTargetPos.z);
//    }
//}
