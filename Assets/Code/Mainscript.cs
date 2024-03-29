using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Mainscript : MonoBehaviour
{
    public bool CPU = false;

    public GameObject Broom;

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
    public int end = 1;
    public int Rturn = 1;
    public int Bturn = 1;
    public string turncolor = "Red";
    public int Time = 1;
    public bool Timechk = false;
    public bool play = true;

    public int[] rscore = { 0, 0, 0, 0 };
    public int[] bscore = { 0, 0, 0, 0 };
    public int R1;
    public int R2;
    public int totalrscore;
    public int totalbscore;
    public Text EndText;


    public RectTransform startbtn;
    public RectTransform upbtn;
    public RectTransform downbtn;
    public RectTransform Gaze;
    public Vector2 newPosition;
    public bool inputstart = false;
    public bool inputup = false;
    public bool inputdown = false;

    public void startclick()
    {
        if (inputstart) {
            inputstart = false;
            play = false;
            newPosition = new Vector2(0f, -700f);
            startbtn.anchoredPosition = newPosition;
            newPosition = new Vector2(300f, 150f);
            upbtn.anchoredPosition = newPosition;
            newPosition = new Vector2(-300f, 150f);
            downbtn.anchoredPosition = newPosition;
        }
        else {
            inputstart = true;
            Timechk = true;
            GetComponent<AudioSource>().Play();
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
            Broom.SendMessage("broomsound");
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
            Broom.SendMessage("broomsound");
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
    // 상시 작동
    void Update()
    {
        if ((turncolor == "Red") && (Rturn < 7)) {
            Red[Rturn].SendMessage("GetReady");
            Red[Rturn].SendMessage("ObjMove");
            Red[Rturn].SendMessage("ShotEnd");
        }
        else if ((turncolor == "Blue") && (Bturn < 7)) {
            Blue[Bturn].SendMessage("GetReady");
            Blue[Bturn].SendMessage("ObjMove");
            Blue[Bturn].SendMessage("ShotEnd");
        }

        else {
            Debug.Log("calc");
            calc();
            set();
        }

    }
    
    void FixedUpdate() // 0.02초에 한번씩 작동 == 1초에 50번 작동한다
    {
        if (Timechk) { Time++; }

        if ((turncolor == "Red") && (Rturn < 7)) {
            R1 = Random.Range(1, 7);
            R2 = Random.Range(1, 4);
            Red[Rturn].SendMessage("GetReady");
            Red[Rturn].SendMessage("Throw");
        }

        if ((turncolor == "Blue") && (Bturn < 7) && !CPU) {
            Blue[Bturn].SendMessage("GetReady");
            Blue[Bturn].SendMessage("Throw");
        }

        if ((turncolor == "Blue") && (Bturn < 7) && CPU)
        {
            CPUUI();
            CPUAI();
            Blue[Bturn].SendMessage("GetReady");
            Blue[Bturn].SendMessage("Throw");
        }
    }

    void CPUUI() 
    {
        newPosition = new Vector2(0f, -700f);
        startbtn.anchoredPosition = newPosition;
        newPosition = new Vector2(300f, 1500f);
        upbtn.anchoredPosition = newPosition;
        newPosition = new Vector2(-300f, 1500f);
        downbtn.anchoredPosition = newPosition;
    }

    void CPUAI() 
    {
        Debug.Log(R1);
        Debug.Log(R2);
        Timechk = true;
        inputstart = true;
        if (R1 == 2) { if (Time > 140) { inputstart = false; } }
        if (R1 == 3) { if (Time > 160) { inputstart = false; } }
        else { if (Time > 147) { inputstart = false; } }

        if (Time == 160) {
            play = false;
        }

        if (Time % 20 == 0)
        {
            if (R2 == 1) { inputup = true; }
            if (R2 == 2) { inputdown = true; }
            if (R2 == 3) {}
        }
        else 
        {
            inputup = false;
            inputdown = false;
        }
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

        Debug.Log("Red: " + Rpos);
        Debug.Log("Blue: " + Bpos);

        if (Rpos < Bpos)
        {
            Debug.Log("RedWin");
            for (int i = 1; i < Red.Length; i++) {
                Transform RStoneTransform = Red[i].transform;
                Vector3 pos = RStoneTransform.position;
                Nowpos = Mathf.Sqrt((Mathf.Pow((17.1f - pos.x), 2f) + Mathf.Pow((pos.z), 2f)));
                if (Nowpos < 2f) {
                    rscore[end - 1] += 1;
                    totalrscore += 1;
                }

            }
        }
        else {
            Debug.Log("BlueWin");
            for (int i = 1; i < Blue.Length; i++) {
                Transform BStoneTransform = Blue[i].transform;
                Vector3 pos = BStoneTransform.position;
                Nowpos = Mathf.Sqrt((Mathf.Pow((17.1f - pos.x), 2f) + Mathf.Pow((pos.z), 2f)));
                if (Nowpos < 2f)
                {
                    bscore[end - 1] += 1;
                    totalbscore += 1;
                }
            }
        }

        if (turncolor == "Red") 
        {
            turncolor = "Blue"; 
        }
        else {
            turncolor = "Red"; 
        }
        

        end += 1;
        if (end != 5)
        {
            EndText.text = end.ToString();
        }
        
            
        if (end == 5) // 4세트가 모두 끝났을 때
        { 
            if (totalrscore > totalbscore)
            {
                Debug.Log("Redtotalwin");
                GameObject.Find("UI Canvas").GetComponent<GameUI>().RedWin();

            }
            else if (totalrscore < totalbscore)
            {
                Debug.Log("BluetotalWin");
                GameObject.Find("UI Canvas").GetComponent<GameUI>().BlueWin();
            }
            else
            {
                Debug.Log("draw");
                GameObject.Find("UI Canvas").GetComponent<GameUI>().Draw();
            }
        }
    }



void set()
{
    Rturn = 1;
    Bturn = 1;
    for (int i = 1; i < Red.Length; i++)
    {
        Red[i].transform.position = new Vector3((-17.3f + (0.35f * i)), 0.6f, 2f);
    }

    for (int i = 1; i < Blue.Length; i++)
    {
        Blue[i].transform.position = new Vector3((-17.3f + (0.35f * i)), 0.6f, -2f);
    }
}

}
