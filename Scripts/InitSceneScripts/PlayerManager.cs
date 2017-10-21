using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

    public GameObject SpawnPoint;

    private void Awake()
    {
        print("AWAKE");
        //PlayerPrefs.SetFloat("X", transform.position.x);
        //PlayerPrefs.SetFloat("Y", transform.position.y);
        //PlayerPrefs.SetFloat("Z", transform.position.z);

    }

   

    private void OnEnable()
    {
        print(PlayerPrefs.GetFloat("X"));
        Vector3 PlayerPrevPosition = new Vector3(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y"), PlayerPrefs.GetFloat("Z"));
        transform.position = PlayerPrevPosition;

    }


    private void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("X", SpawnPoint.transform.position.x);
        PlayerPrefs.SetFloat("Y", SpawnPoint.transform.position.y);
        PlayerPrefs.SetFloat("Z", SpawnPoint.transform.position.z);


    }
    








}
