using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMove : MonoBehaviour
{
    float power = 2.0f;
    Rigidbody rb;

    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update() {
        Vector3 pos;
        pos = transform.position; // 현제 오브젝트 위치

        if (pos.x < -11.0f){
            if (Input.GetKey(KeyCode.Space)){
                if ((-18.0f < pos.x)&&(power == 2.0f)){
                    power = power + 3.0f;
                    Debug.Log(power);
                }
                if ((-15.0f < pos.x))
                {
                    Debug.Log(power);
                }
                if ((-13.0f < pos.x)&&(power == 5.0f)){
                    power = power + 5.0f;
                    Debug.Log(power);
                }
                rb.AddForce(Vector3.right * power);
                /*Debug.Log("스페이스 키 누르는 중");*/
            }
        }
    }

    void LastUpdate() { }
}

/*Rigidbody rb;
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
}*/