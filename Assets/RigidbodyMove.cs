
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMove : MonoBehaviour
{
    Rigidbody rb;
    float power = 200f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            rb.AddForce(Vector3.left * power);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            rb.AddForce(Vector3.right * power);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            rb.AddForce(Vector3.forward * power);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            rb.AddForce(Vector3.back * power);
        }
    }
}
