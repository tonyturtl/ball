using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmovement : MonoBehaviour
{
    //variables for the game
    public float xSpeed = 0.5f; //variable for the movement on the x-axis
    public float xBorder = 7.5f;
    private bool xMove = true;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (xMove == true) {
            transform.position = new Vector2 (transform.position.x + xSpeed, transform.position.y);
        }
        if (transform.position.x>=xBorder) {
            xMove = false;
        }
    }
}