using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainscript : MonoBehaviour
{
    public GameObject Rstone_1;
    public GameObject Rstone_2;
    public GameObject Rstone_3;
    public GameObject Rstone_4;
    public GameObject Rstone_5;
    public GameObject Rstone_6;

    GameObject[] Red = new GameObject[7];

    public GameObject Bstone_1;
    public GameObject Bstone_2;
    public GameObject Bstone_3;
    public GameObject Bstone_4;
    public GameObject Bstone_5;
    public GameObject Bstone_6;

    GameObject[] Blue = new GameObject[7];

    public string turn = "Red1";

    void Start()
    {
         Red[1] = Rstone_1; Red[2] = Rstone_2;
         Red[3] = Rstone_3; Red[4] = Rstone_4;
         Red[5] = Rstone_5; Red[6] = Rstone_6;

         Blue[1] = Bstone_1; Blue[2] = Bstone_2;
         Blue[3] = Bstone_3; Blue[4] = Bstone_4;
         Blue[5] = Bstone_5; Blue[6] = Bstone_6;

        Debug.Log("start");
    }

    void Update()
    {
        if (turn == "Red1")
        {
            Red[1].SendMessage("Throw");
        }
        else if(turn == "Red2")
        {
            Red[2].SendMessage("Throw");
        }
        else if(turn == "Red3")
        {
            Red[3].SendMessage("Throw");
        }
        else if(turn == "Red4")
        {
            Red[4].SendMessage("Throw");
        }
        else if(turn == "Red5")
        {
            Red[5].SendMessage("Throw");
        }
        else if(turn == "Red6")
        {
            Red[6].SendMessage("Throw");
        }


        else if(turn == "Blue1")
        {
            Blue[1].SendMessage("Throw");
        }
        else if(turn == "Blue2")
        {
            Blue[2].SendMessage("Throw");
        }
        else if(turn == "Blue3")
        {
            Blue[3].SendMessage("Throw");
        }
        else if(turn == "Blue4")
        {
            Blue[4].SendMessage("Throw");
        }
        else if(turn == "Blue5")
        {
            Blue[5].SendMessage("Throw");
        }
        else if(turn == "Blue6")
        {
            Blue[6].SendMessage("Throw");
        }


        else {
            Debug.Log("calc");
            calc();
        }
    }

    void calc()
    {
        //하우스 중앙의 좌표 x=17.1, z=0
        //피타고라스 법칙 사용 a^2 + b^2 = C^2 직각 삼각형 일떄 대각선의 길이 구하기
        float Rpos = 100;
        float Bpos = 100;
        float Nowpos = 0;


        for (int i = 1; i < Red.Length; i++)
        {
            Transform RStoneTransform = Red[i].transform;
            Vector3 pos = RStoneTransform.position;
            Nowpos = Mathf.Sqrt(((17.1f - pos.x) * (17.1f - pos.x)) + ((0 - pos.y) * (0 - pos.y)));
            if (Rpos > Nowpos)
            {
                Rpos = Nowpos;
            }
        }

        for (int i = 1; i < Blue.Length; i++)
        {
            Transform BStoneTransform = Blue[i].transform;
            Vector3 pos = BStoneTransform.position;
            Nowpos = Mathf.Sqrt(((17.1f - pos.x) * (17.1f - pos.x)) + ((0 - pos.y) * (0 - pos.y)));
            if (Bpos > Nowpos)
            {
                Bpos = Nowpos;
            }
        }

        Debug.Log(Rpos);
        Debug.Log(Bpos);

        if (Rpos < Bpos)
        {
            Debug.Log("RedWin");
        }
        else {
            Debug.Log("BlueWin");
        }

    }
}
