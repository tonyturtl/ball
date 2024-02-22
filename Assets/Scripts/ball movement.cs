using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmovement : MonoBehaviour
{
    //variables for the game
    public float xSpeed = 0.025f; //variable for the movement on the x-axis
    public float xBorder = 10f;
    public bool xMove = true;
    public bool yMove = true;
    public float ySpeed = 0.025f; //variable for the movement on the y-axis
    public float yBorder = 4.5f; 

    // Start is called before the first frame update
    void Start()

    {

    }
    
    // Update is called once per frame
    void Update()
    {
        if (xMove == true) {
            transform.position = new Vector2 (transform.position.x + xSpeed, transform.position.y);
        }
        else {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y);
        }
  
        if (transform.position.x >= xBorder) {
            xMove = false;
        }
        else if (transform.position.x <= -xBorder)
        {
            xMove=true; 
        }
        if (yMove == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed);
        }
        else {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed);
        }
        if (transform.position.y >=yBorder)
        {
            yMove = false;
        }
        else if (transform.position.y <= -yBorder)
        {
            yMove=true;
        }
    }
        void OnCollisionEnter2D(Collision2D collision) {
        
            if (collision.collider.CompareTag ("RPlayer"))
            {
                Debug.Log("hit");
                if (xMove == true)
                {
                    xMove = false; 
                }
                else if (xMove == false)
                {
                    xMove = true;
                }
            }

        }




}