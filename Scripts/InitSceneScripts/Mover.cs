using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    //movement variables
    public float maxSpeed;
    
    //jumping variables
    

    public Transform playerSprite;
   

    Rigidbody myRB;
    

    bool facingRight;



    // Use this for initialization.
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        
        facingRight = true;
    }

    

      
    void FixedUpdate()
    {
          
        float move = Input.GetAxis("Horizontal");
        float move2 = Input.GetAxis("Vertical");
        myRB.velocity = new Vector3(move * maxSpeed, myRB.velocity.y, move2 * maxSpeed);
       
        
        if (move > 0 && facingRight != true)
        {
            flip();
        }
        else if (move < 0 && facingRight)
        {
            flip();
        }
    }

    void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = playerSprite.transform.localScale;
        theScale.x *= -1;

        playerSprite.transform.localScale = theScale;
    }

   
}
