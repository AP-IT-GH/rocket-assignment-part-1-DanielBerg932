using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed = 50;
    public int sec = 20;

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

            transform.Translate(Vector3.up * speed * Time.deltaTime);
            myRb.useGravity = false;
        }
    }


    public void MoveWithArrows()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
        }
    }
}
