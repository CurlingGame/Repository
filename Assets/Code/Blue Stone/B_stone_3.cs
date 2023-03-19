using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_stone_3 : MonoBehaviour
{
    bool setting = true;                // 스톤을 던지기 전 오브젝트들 위치 초기화 함수를 위한 트리거
    bool play = true;                   // 스톤을 1회성으로 던지기 위한 트리거
    float time = 0;
    public GameObject Lbroom;
    public GameObject Rbroom;           // 브룸
    public GameObject FrontCam;         // A 지점에서의 카메라 - 스톤의 뒤쪽
    public GameObject UpCam;            // B C 지점에서의 카메라 - 스톤의 위쪽

    Mainscript mainscript;              // Mainscript 의 변수를 사용하기 위함

    void Ready()
    {
        FrontCam.SetActive(true);
        UpCam.SetActive(false);                                     // 작동하는 카메라 지정
        transform.position = new Vector3(-19f, 0.6f, 0f);           // 스톤의 위치 초기화
        FrontCam.transform.position = new Vector3(-20.5f, 2f, 0f);  // 카메라의 위치 초기화
        UpCam.transform.position = new Vector3(-10f, 5.5f, 0f);
        Rbroom.transform.position = new Vector3(-10f, 0.8f, -1f);   // 브룸의 위치 초기화
        Lbroom.transform.position = new Vector3(-10f, 0.8f, 1f);

        mainscript = GameObject.Find("Sheet").GetComponent<Mainscript>(); // Mainscript 의 변수를 사용하기 위함

        setting = false;
    }

    void failstone()
    {
        transform.position = new Vector3(-22f, 0.6f, 2f);
    }
    // 스톤을 잘못 던졌을경우 스톤을 비활성화 시키는 코드

    void Throw()
    {
        if (setting) { Ready(); }

        // 스톤의 현제 위치 찾기
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 pos;
        pos = transform.position;

        // A 지점
        if (play && (pos.x < -11 && Input.GetMouseButton(2)))
        {
            rb.AddForce(Vector3.right * 6f);
            FrontCam.transform.position = new Vector3(-1.5f + pos.x, 2f, 0f);
        }
        if (Input.GetMouseButtonUp(2))
        {
            play = false;
        }

        // B 지점
        if ((pos.x > -11) && (pos.x <= 13))
        {
            FrontCam.SetActive(false);
            UpCam.SetActive(true);
            Rbroom.transform.position = new Vector3(1f + pos.x, 0.8f, -1f);
            Lbroom.transform.position = new Vector3(1f + pos.x, 0.8f, 1f);

            if (Input.GetMouseButton(0))
            {
                Lbroom.transform.position = new Vector3(1f + pos.x, 0.8f, 1.3f);
                rb.AddForce(Vector3.forward * 3);
            }

            if (Input.GetMouseButton(1))
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
            Debug.Log("time");                          // 진행을 위한 시간 추가 ( update문 프레임 단위로 계산 )
            if (time > 6000)
            {
                Debug.Log("end1 good shot");
                mainscript.turn = "Red4";
            }
            if ((time > 2000) && (pos.x < -10.5f))
            {
                Debug.Log("end2 shot fail");
                failstone();
                mainscript.turn = "Red4";
            }
            if ((time > 5000) && (pos.x < 10.5f))
            {
                Debug.Log("end3 week shot");
                mainscript.turn = "Red4";
            }
        }
    }
}
