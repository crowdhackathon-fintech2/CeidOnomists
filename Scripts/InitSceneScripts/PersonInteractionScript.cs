using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersonInteractionScript : MonoBehaviour {

    public Transform Player;
    //public float maxDistanceFromPlayer = 2f;.
    public GameObject Pivot;
    public GameObject[] UIElements;
   

    private float distance;
    private Vector3 PivotPosition;
 

   void Start ()
   {
           if (UIElements == null)
           {
               UIElements = GameObject.FindGameObjectsWithTag("UI");
               
           }
        

    }

   
     void OnTriggerEnter(Collider other)
    {

        if (other = Player.GetComponent<Collider>())
        {
            transform.tag = "Interactioner";
            //print("EISAI KONTA");
            foreach (GameObject UIElement in UIElements)
            {
                UIElement.SetActive(true);


            }
            transform.GetChild(1).transform.position = Pivot.transform.position;
            transform.GetChild(1).gameObject.SetActive(true);
            Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            Player.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = false;
            transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = false;
            
            
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other = Player.GetComponent<Collider>())
    //    {

    //       SceneManager.LoadScene("DialogueScene", LoadSceneMode.Single);
    //    }
    //}
}
