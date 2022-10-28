using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed = 5;

    private Rigidbody myRb;
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        myRb.useGravity = true;
        MoveWithArrows();
        MoveWithSpace();
    }
    public void MoveWithSpace()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRb.AddForce(Vector3.up * speed, ForceMode.Impulse);
        }
    }


    public void MoveWithArrows()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * -15* Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward * 15* Time.deltaTime);
        }
    }
}
