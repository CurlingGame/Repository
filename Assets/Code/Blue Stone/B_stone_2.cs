using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_stone_2 : MonoBehaviour
{
    bool set = false;
    public GameObject Lbroom;
    public GameObject Rbroom;
    public GameObject FrontCam;
    public GameObject UpCam;

    public GameObject Startbtn;
    public GameObject Lbroombtn;
    public GameObject Rbroombtn;

    Mainscript mainscript;

    void Ready()
    {
        Debug.Log("set");
        FrontCam.SetActive(true);
        UpCam.SetActive(false);
        transform.position = new Vector3(-19f, 0.6f, 0f);
        FrontCam.transform.position = new Vector3(-20.5f, 2f, 0f);
        UpCam.transform.position = new Vector3(-10f, 5.5f, 0f);
        Rbroom.transform.position = new Vector3(-10f, 0.8f, -1f);
        Lbroom.transform.position = new Vector3(-10f, 0.8f, 1f);

        mainscript = GameObject.Find("Sheet").GetComponent<Mainscript>();
    }

    void GetReady()
    {
        if (!set)
        {
            Ready();
            set = true;
        }

    }

    void CamMove()
    {
        Vector3 pos = transform.position;

        FrontCam.transform.position = new Vector3(-1.5f + pos.x, 2f, 0f);
        UpCam.transform.position = new Vector3(pos.x, 5.5f, 0f);

        if (pos.x > -11)
        {
            FrontCam.SetActive(false);
            UpCam.SetActive(true);
        }
    }

    void BroomMove()
    {
        Vector3 pos = transform.position;

        if ((pos.x > -11) && (pos.x <= 13))
        {
            Rbroom.transform.position = new Vector3(1f + pos.x, 0.8f, -1f);
            Lbroom.transform.position = new Vector3(1f + pos.x, 0.8f, 1f);

            if (mainscript.inputup)
            {
                Lbroom.transform.position = new Vector3(1f + pos.x, 0.8f, 1.3f);
            }
            if (mainscript.inputdown)
            {
                Rbroom.transform.position = new Vector3(1f + pos.x, 0.8f, -1.3f);
            }
        }
    }

    void ObjMove()
    {
        CamMove();
        BroomMove();
    }

    void Throw()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 pos = transform.position;

        if (pos.x < -11 && mainscript.inputstart && mainscript.play)
        {
            rb.AddForce(Vector3.right * 40f);
        }

        if ((pos.x > -11) && (pos.x <= 13))
        {
            if (mainscript.inputup)
            {
                rb.AddForce(Vector3.forward * 10);
            }

            if (mainscript.inputdown)
            {
                rb.AddForce(Vector3.back * 10);
            }

        }
    }

    void ShotEnd()
    {
        Vector3 pos = transform.position;

        if (mainscript.Time > 300)
        {
            if (pos.x < -10.5f)
            {
                Debug.Log("end2 shot fail");
                failstone();
                Throwend();
            }
        }
        if (mainscript.Time > 1000)
        {
            if (pos.x < 10.5f)
            {
                Debug.Log("end3 week shot");
                failstone();
            }
            else { Throwend(); }
        }
    }

    void failstone()
    {
        transform.position = new Vector3(-22f, 0.6f, 2f);
    }

    void Throwend()
    {
        set = false;
        mainscript.play = true;
        mainscript.Timechk = false;
        mainscript.Time = 0;
        mainscript.turncolor = "Red";
        mainscript.Bturn++;
    }
}
