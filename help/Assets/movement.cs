using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right* movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * movementSpeed * Time.deltaTime;
        }

        float mouseXMovement = Input.GetAxis("Mouse X");
        //Debug.Log(mouseXMovement);
        transform.Rotate(0, mouseXMovement, 0);
        float mouseYMovement = Input.GetAxis("Mouse Y");
        Camera.main.transform.Rotate(-mouseYMovement, 0, 0);
    }
}
