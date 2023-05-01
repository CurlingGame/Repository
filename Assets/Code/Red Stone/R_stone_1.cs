using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_stone_1 : MonoBehaviour
{
    bool setting = true;               // ������ ������ �� ������Ʈ�� ��ġ �ʱ�ȭ �Լ��� ���� Ʈ����
    bool play = true;                   // ������ 1ȸ������ ������ ���� Ʈ����
    float time = 0;
    public GameObject Lbroom;
    public GameObject Rbroom;           // ���
    public GameObject FrontCam;         // A ���������� ī�޶� - ������ ����
    public GameObject UpCam;            // B C ���������� ī�޶� - ������ ����

    public GameObject Startbtn;
    public GameObject Lbroombtn;
    public GameObject Rbroombtn;
    
    Mainscript mainscript;              // Mainscript �� ������ ����ϱ� ����
    Throwbtn throwbtn;
    UPbutton upbtn;
    Downbutton downbtn;

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
        throwbtn = FindObjectOfType<Throwbtn>();
        upbtn = FindObjectOfType<UPbutton>();
        downbtn = FindObjectOfType<Downbutton>();

        setting = false;
    }

    void failstone()
    {
        transform.position = new Vector3(-22f, 0.6f, 2f);
        /*gameObject.SetActive(false);*/
    }

    void Throwend() {
        setting = true;
        play = true;
        time = 0;
        mainscript.turncolor = "Blue";
        mainscript.Rturn++;

    }

    void Throw()
    {
        if (setting) { Ready(); }

        // ������ ���� ��ġ ã��
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 pos;
        pos = transform.position;

        // A ����
        if (play && (pos.x < -11 && throwbtn.isBtnDown))
        {
            rb.AddForce(Vector3.right * 7f);
            FrontCam.transform.position = new Vector3(-1.5f + pos.x, 2f, 0f);
        }
        if (Input.GetMouseButtonUp(2))
        {
            play = false;
        }

        // B ����
        if ((pos.x > -11) && (pos.x <= 13))
        {
            FrontCam.SetActive(false);
            UpCam.SetActive(true);

            Rbroom.transform.position = new Vector3(1f + pos.x, 0.8f, -1f);
            Lbroom.transform.position = new Vector3(1f + pos.x, 0.8f, 1f);

            if (upbtn.isBtnDown)
            {
                Lbroom.transform.position = new Vector3(1f + pos.x, 0.8f, 1.3f);
                rb.AddForce(Vector3.forward * 3);
            }

            if (downbtn.isBtnDown)
            {
                Rbroom.transform.position = new Vector3(1f + pos.x, 0.8f, -1.3f);
                rb.AddForce(Vector3.back * 3);
            }

        }

        if (pos.x < 18)
        {
            UpCam.transform.position = new Vector3(pos.x, 5.5f, 0f);

        }

        if ((!play) || (pos.x > -11))
        {
            time++;
            Debug.Log("time");                          // ������ ���� �ð� �߰� ( update�� ������ ������ ��� )
            if (time > 6000)
            {
                Debug.Log("end1 good shot");
                Throwend();
            }
            if ((time > 2000) && (pos.x < -10.5f))
            {
                Debug.Log("end2 shot fail");
                failstone();
                Throwend();
            }
            if ((time > 5000) && (pos.x < 10.5f))
            {
                Debug.Log("end3 week shot");
                Throwend();
            }
        }
    }
}
