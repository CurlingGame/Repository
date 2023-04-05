using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    
    public static int rscore;
    public static int bscore;

    // Start is called before the first frame update
    void Awake()
    {
        rscore = 0;
        bscore = 0;
        
    }
}
