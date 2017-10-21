using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    // PersonInteractionScript ScriptReference;
    //GameObject[] UIelements = ScriptReference.UIElements;

    // go.GetComponent<Scriptname>().listname;

    public Transform Player;
    private GameObject otherOne;
    GameObject[] myList;
    void Start()
    {
      
        otherOne = GameObject.FindGameObjectWithTag("Interactioner");
        
    }
    
    

    public void OnClick()
    {
        myList = otherOne.GetComponent<PersonInteractionScript>().UIElements;
        print("HELLO");
        

        foreach (GameObject UIElement in myList)
        {
            UIElement.SetActive(false);


        }
        
        otherOne.transform.GetChild(1).gameObject.SetActive(false);
        Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        Player.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        otherOne.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = true;

        otherOne.tag = "Untagged";
    }
}
