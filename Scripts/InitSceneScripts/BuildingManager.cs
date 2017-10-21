using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildingManager : MonoBehaviour {

    public Transform Player;

    
    

    private void OnTriggerStay(Collider other)
    {
        if (other = Player.GetComponent<Collider>())
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                print("MPIKE\n" + "XRONOS: " + Time.unscaledTime);
                PlayerPrefs.SetFloat("X", Player.transform.position.x);
                PlayerPrefs.SetFloat("Y", Player.transform.position.y);
                PlayerPrefs.SetFloat("Z", Player.transform.position.z);
                //SceneManager.MoveGameObjectToScene(GameObject.FindGameObjectWithTag("EconomicManager"), SceneManager.GetSceneByName("CasinoRoulete"));
                SceneManager.LoadScene("CasinoRoulete", LoadSceneMode.Single);
                //Object.DontDestroyOnLoad(GameObject.FindGameObjectWithTag("EconomicManager"));

            }
        }
    }
}
