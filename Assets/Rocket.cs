﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody rigidbody;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
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
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
     
        } else
        {
            if(audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
        if(Input.GetKey(KeyCode.A))
        {
            //rigidbody.AddRelativeForce(Vector3.left);
            transform.Rotate(Vector3.forward);
          
        } else if(Input.GetKey(KeyCode.D)) {
            //rigidbody.AddRelativeForce(Vector3.right);
            transform.Rotate(-Vector3.forward);


        }
    }
}
