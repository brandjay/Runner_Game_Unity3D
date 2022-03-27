using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float moveSpeed = 15f;
    public float mousesenX = 1f;
    public float mousesenY = 1f;
    //var distance = float = 5;
    public float distance = 5;
    float verticalLockRotation;
    Transform mainCam;


    //hides mouse cursor in game window press esc key to unlock cursor 
    void Awake()
    {
        mainCam = Camera.main.transform;
    }
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //transform.position = mainCam.transform.forward * moveSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mousesenX);
        verticalLockRotation += Input.GetAxis("Mouse Y") * mousesenY;

        //move charcter in direction the camera is facing
        transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime;



        //controls and movement for the 4 main keys
        Vector3 position = transform.position;

        if (Input.GetKey("w"))
        {
            position.z += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            position.z -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            position.x += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            position.x -= moveSpeed * Time.deltaTime;
        }

        transform.position = position;
    }
}


