using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BScore_Update : MonoBehaviour
{

    
    Text bscoreLabel;

    void Awake()
    {
        
        bscoreLabel = GetComponent<Text>();
    }

    void Update()
    {
        
        bscoreLabel.text = Score_Manager.bscore.ToString();
    }
}
