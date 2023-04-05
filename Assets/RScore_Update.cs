using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RScore_Update : MonoBehaviour { 

    Text rscoreLabel;
    

    void Awake ()
    {
        rscoreLabel = GetComponent<Text>();
    }

    void Update ()
    {
        rscoreLabel.text = Score_Manager.rscore.ToString();
    }
}
