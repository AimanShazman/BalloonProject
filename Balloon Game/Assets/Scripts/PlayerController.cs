using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float thirdOfGroundWidth;
    private Vector3 playerMovement;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        thirdOfGroundWidth = GameObject.Find("Ground").transform.localScale.x / 3;
        playerMovement = new Vector3(thirdOfGroundWidth, 0, 0);
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
            if(transform.position.x == -thirdOfGroundWidth)
            {
                transform.position = new Vector3(-thirdOfGroundWidth, transform.position.y, transform.position.z);
            } else
            {
                transform.position = transform.position - playerMovement;
            }
        }
        
        if(Input.GetKeyDown(KeyCode.D))
        {
            //right Boundary
            if(transform.position.x == thirdOfGroundWidth)
            {
                transform.position = new Vector3(thirdOfGroundWidth, transform.position.y, transform.position.z);
            } else
            {
                transform.position = transform.position + playerMovement;
            }
        }
    }
}
