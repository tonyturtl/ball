using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    // variables for the code
    public float speed = 8f;
    public float yBorder = 4.5f; 
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //declare value of the variable
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = rb2d.velocity;   //create and declare variable for velocity 

        //control the paddle
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= yBorder) // when UpArrow is pressed)
        {
         velocity.y = speed;         //move the speed up
         Debug.Log ("UpArrow");
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -yBorder) //when DownArrow is pressed)
        {
            velocity.y =-speed;     //move the speed down
             Debug.Log ("DownArrow");
        }
        else {                  //otherwise 
        velocity.y = 0;         //dont move
     }
     rb2d.velocity = velocity;
    }
}




