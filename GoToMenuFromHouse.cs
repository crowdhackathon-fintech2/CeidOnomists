using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenuFromHouse : MonoBehaviour {

    public Transform Player;

    private void OnTriggerStay(Collider other)
    {
        if (other = Player.GetComponent<Collider>())
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                PlayerPrefs.SetFloat("X", Player.transform.position.x);
                PlayerPrefs.SetFloat("Y", Player.transform.position.y);
                PlayerPrefs.SetFloat("Z", Player.transform.position.z);
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
        }
    }
}
