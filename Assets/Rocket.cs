﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector3.up);
            print("power");
        }
        if(Input.GetKey(KeyCode.A))
        {
            rigidbody.AddRelativeForce(Vector3.left);

            print("lewo");
        } else if(Input.GetKey(KeyCode.D)) {
            rigidbody.AddRelativeForce(Vector3.right);
            print("prawo");
        }
    }
}
