﻿using UnityEngine;

using System.Collections;


//Author: J.Anderson

public class PlayerCollisions : MonoBehaviour
{

    public bool isGrounded;


    public void OnCollisionEnter(Collision collision)
    {

    }

    public void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Ground")
            isGrounded = true;
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Ground")
            isGrounded = false;
    }

    public void OnTriggerEnter(Collider other)
    {

    }
    public void OnTriggerStay(Collider other)
    {

    }

    public void OnTriggerExit(Collider other)
    {

    }
}