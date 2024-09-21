using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float thirdOfGroundWidth;
    private float[] playerMovement;
    private int leftPositionIndex = 0;
    private int rightPositionIndex = 2;
    private int currentPositionIndex = 1;


    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetMoveablePosition();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            //left Boundary
            if(transform.position.x == playerMovement[leftPositionIndex])
            {
                transform.position = new Vector3(playerMovement[leftPositionIndex], transform.position.y, transform.position.z);
            } 
            else 
            {
                transform.position = new Vector3(playerMovement[--currentPositionIndex], transform.position.y, transform.position.z);
            }
        }
        
        if(Input.GetKeyDown(KeyCode.D))
        {
            //right Boundary
            if(transform.position.x == playerMovement[rightPositionIndex])
            {
                transform.position = new Vector3(playerMovement[rightPositionIndex], transform.position.y, transform.position.z);
            } 
            else 
            {
                transform.position = new Vector3(playerMovement[++currentPositionIndex], transform.position.y, transform.position.z);
            }
        }
    }

    public float[] GetMoveablePosition()
    {
        thirdOfGroundWidth = GameObject.Find("Ground").transform.localScale.x / 3;
        float[] playerMovement = new float[] {-thirdOfGroundWidth, 0, thirdOfGroundWidth};

        return playerMovement;
    }


}
