using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float backgroundWidth;
    // private Vector3 startPos;
    private Vector3 playerMovement;

    // private Vector3 playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        // startPos = transform.position;
        backgroundWidth = GameObject.Find("Background").GetComponent<BoxCollider>().size.x / 3;
        playerMovement = new Vector3(backgroundWidth, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position - playerMovement;
        }
        
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position + playerMovement;
        }

        
    }
}
