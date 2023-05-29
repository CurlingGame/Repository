using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_stone_4 : MonoBehaviour
{
    bool set = false;
    public GameObject Lbroom;
    public GameObject Rbroom;           // ���
    public GameObject FrontCam;         // A ���������� ī�޶� - ������ ����
    public GameObject UpCam;            // B C ���������� ī�޶� - ������ ����

    public GameObject Startbtn;
    public GameObject Lbroombtn;
    public GameObject Rbroombtn;

    public RectTransform startbtn;
    public RectTransform upbtn;
    public RectTransform downbtn;
    public Vector2 newPosition;

    Mainscript mainscript;              // Mainscript �� ������ ����ϱ� ����

    void Ready()
    {
        Debug.Log("set");
        FrontCam.SetActive(true);
        UpCam.SetActive(false);                                     // �۵��ϴ� ī�޶� ����
        transform.position = new Vector3(-19f, 0.6f, 0f);           // ������ ��ġ �ʱ�ȭ
        FrontCam.transform.position = new Vector3(-20.5f, 2f, 0f);  // ī�޶��� ��ġ �ʱ�ȭ
        UpCam.transform.position = new Vector3(-10f, 5.5f, 0f);
        Rbroom.transform.position = new Vector3(-10f, 0.8f, -1f);   // ����� ��ġ �ʱ�ȭ
        Lbroom.transform.position = new Vector3(-10f, 0.8f, 1f);

        mainscript = GameObject.Find("Sheet").GetComponent<Mainscript>(); // Mainscript �� ������ ����ϱ� ����
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

        if (pos.x >= 13)
        {
            updownbtndown();
        }
    }

    void ObjMove()
    {
        CamMove();
        BroomMove();
    }

    void Throw()
    {
        // ������ ���� ��ġ ã��
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 pos = transform.position;

        // A ����
        if (pos.x < -11 && mainscript.inputstart && mainscript.play)
        {
            rb.AddForce(Vector3.right * 40f);
        }

        // B ����
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

    public void startbtnmove()
    {
        newPosition = new Vector2(0f, 100f);
        startbtn.anchoredPosition = newPosition;
    }

    public void updownbtndown()
    {
        newPosition = new Vector2(0f, -700f);
        upbtn.anchoredPosition = newPosition;
        downbtn.anchoredPosition = newPosition;
    }

    void failstone()
    {
        transform.position = new Vector3(-21.5f, 0.6f, 2f);
    }

    void Throwend()
    {
        set = false;
        mainscript.play = true;
        mainscript.Timechk = false;
        mainscript.Time = 0;
        mainscript.turncolor = "Blue";
        mainscript.Rturn++;
        startbtnmove();
        updownbtndown();
    }
}
