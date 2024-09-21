using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 4;
    private float zBoundary = -7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        DestroyObject();
    }

    private void DestroyObject()
    {
        if(transform.position.z < zBoundary)
        {
            Destroy(gameObject);
        }
        
    }
}
