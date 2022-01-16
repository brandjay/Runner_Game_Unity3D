using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float moveSpeed = 15f;
    public float mousesenX = 1f;
    public float mousesenY = 1f;
    float verticalLockRotation;
    Transform mainCam;


    //hides mouse cursor in game window press esc key to unlock cursor 
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
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
        //verticaLockRotation = Mathf.Clamp(verticalLockRotation, -80 80);
        mainCam.localEulerAngles = Vector3.left * verticalLockRotation;


        //controls and movement for the 4 main keys
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


