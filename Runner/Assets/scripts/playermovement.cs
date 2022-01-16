using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float moveSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //input from player
        Vector3 posit = transform.position;

        if (Input.GetKey("w"))
        {
            posit.z += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            posit.z -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            posit.x += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            posit.x -= moveSpeed * Time.deltaTime;
        }


        transform.position = posit;
    }
}


