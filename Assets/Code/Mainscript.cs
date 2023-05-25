using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public static int turn = 1;
    public int Rturn = 1;
    public int Bturn = 1;
    public string turncolor = "Red";
    public int Time = 1;
    public bool Timechk = false;
    public bool play = true;

    public static int[] rscore = { 0, 0, 0, 0 };
    public static int[] bscore = { 0, 0, 0, 0 };
    public static int totalrscore;
    public static int totalbscore;

    public Text rscoreLabel1;
    public Text rscoreLabel2;
    public Text rscoreLabel3;
    public Text rscoreLabel4;
    public Text totalrscoreLabel;


    public bool inputstart = false;
    public bool inputup = false;
    public bool inputdown = false;

    
    public void startclick()
    {
        if (inputstart) {
            inputstart = false;
            play= false;
        }
        else {
            inputstart = true;
            Timechk = true;
            Debug.Log("START BTN 터치");
        }
    }

    public void upclick()
    {
        if (inputup)
        {
            inputup = false;
        }
        else
        {
            inputup = true;
            Debug.Log("UP BTN 터치");
        }
    }

    public void downclick()
    {
        if (inputdown)
        {
            inputdown = false;
        }
        else
        {
            inputdown = true;
            Debug.Log("Down BTN 터치");
        }
    }

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
        if ((turncolor == "Red")&&(Rturn < 7)){
            Red[Rturn].SendMessage("GetReady");
            Red[Rturn].SendMessage("ObjMove");
            Red[Rturn].SendMessage("ShotEnd");
        }
        else if((turncolor == "Blue")&&(Bturn < 7)){
            Blue[Bturn].SendMessage("GetReady");
            Blue[Bturn].SendMessage("ObjMove");
            Blue[Bturn].SendMessage("ShotEnd");
        }

        else {
            Debug.Log("calc");
            calc();


            // Debug.Log("Red Score: " + rscore);
            // Debug.Log("Blue Score: " + bscore);

            set();
        }
        
    }

    void FixedUpdate() // 0.02초에 한번씩 작동 == 1초에 50번 작동한다
    {
        if ((turncolor == "Red") && (Rturn < 7)) {
            Red[Rturn].SendMessage("GetReady");
            Red[Rturn].SendMessage("Throw");
        }
        if ((turncolor == "Blue") && (Bturn < 7)) {
            Blue[Bturn].SendMessage("GetReady");
            Blue[Bturn].SendMessage("Throw");
        }
        if (Timechk) { Time++; }
    }


    void calc()
    {
        //하우스 중앙의 좌표 x=17.1, z=0
        //하우스 반지름 길이는 1.93 스톤의 반지름 길이는 0.15 둘이 합쳐 2.08
        //피타고라스 법칙 사용 a^2 + b^2 = C^2 직각 삼각형 일떄 대각선의 길이 구하기
        float Rpos = 100;
        float Bpos = 100;
        float Nowpos = 0;


        for (int i = 1; i < Red.Length; i++)
        {
            Transform RStoneTransform = Red[i].transform;
            Vector3 pos = RStoneTransform.position;
            Nowpos = Mathf.Sqrt((Mathf.Pow((17.1f - pos.x), 2f) + Mathf.Pow((pos.z), 2f)));
            if (Rpos > Nowpos)
            {
                Rpos = Nowpos;
            }
        }

        for (int i = 1; i < Blue.Length; i++)
        {
            Transform BStoneTransform = Blue[i].transform;
            Vector3 pos = BStoneTransform.position;
            Nowpos = Mathf.Sqrt((Mathf.Pow((17.1f - pos.x), 2f) + Mathf.Pow((pos.z), 2f)));
            if (Bpos > Nowpos)
            {
                Bpos = Nowpos;
            }
        }

        Debug.Log("Red: "+Rpos);
        Debug.Log("Blue: "+Bpos);

        if (Rpos < Bpos)
        {
            Debug.Log("RedWin");
            turncolor = "Red";
            for (int i = 1; i < Red.Length; i++) {
                Transform RStoneTransform = Red[i].transform;
                Vector3 pos = RStoneTransform.position;
                Nowpos = Mathf.Sqrt((Mathf.Pow((17.1f - pos.x), 2f) + Mathf.Pow((pos.z), 2f)));
                if (Nowpos < 2f) {
                    rscore[turn - 1] += 1;
                    totalrscore += 1;
                }

            }
        }
        else {
            Debug.Log("BlueWin");
            turncolor = "Blue";
            for (int i = 1; i < Blue.Length; i++){
                Transform BStoneTransform = Blue[i].transform;
                Vector3 pos = BStoneTransform.position;
                Nowpos = Mathf.Sqrt((Mathf.Pow((17.1f - pos.x), 2f) + Mathf.Pow((pos.z), 2f)));
                if (Nowpos < 2f)
                {
                    bscore[turn - 1] += 1;
                    totalbscore += 1;
                }
            }
        }
        turn += 1;
    }

    void set() 
    {
        Rturn = 1;
        Bturn = 1;
        for (int i = 1; i < Red.Length; i++) {
            Red[i].transform.position = new Vector3((-17.3f + (0.3f * i)), 0.6f, 2f);
        }

        for (int i = 1; i < Blue.Length; i++)
        {
            Blue[i].transform.position = new Vector3((-17.3f + (0.3f * i)), 0.6f, -2f);
        }
        
    }
}
