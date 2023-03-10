using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_stone : MonoBehaviour
{
    bool play = true;
    public GameObject FrontCam;
    public GameObject UpCam;

    void Ready()
    {
        FrontCam.SetActive(true);
        UpCam.SetActive(false);
        transform.position = new Vector3(-19f, 0.6f, 0f);
    }
    void Throw()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 pos;
        pos = transform.position;
        

        if (play && (pos.x < -11 && Input.GetMouseButton(0)))
        {
            rb.AddForce(Vector3.right * 5);
            FrontCam.transform.position = new Vector3(-1.5f + pos.x, 2f, 0f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            play = false;
            Debug.Log("b");
        }
        if (pos.x > -11)
        {
            FrontCam.SetActive(false);
            UpCam.SetActive(true);
        }
        if (pos.x < 18) 
        {
            UpCam.transform.position = new Vector3(pos.x, 5.5f, 0f);
        }
    }
}
