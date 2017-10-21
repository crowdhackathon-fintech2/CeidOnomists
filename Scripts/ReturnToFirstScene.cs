using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ReturnToFirstScene : MonoBehaviour {


    

    public void ReturnToMainScene()
    {

        SceneManager.LoadScene("_Init", LoadSceneMode.Single);
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //Vector3 PlayerPrevPosition = new Vector3(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y"), PlayerPrefs.GetFloat("Z"));
        //player.transform.position = PlayerPrevPosition;
        

    }

}
