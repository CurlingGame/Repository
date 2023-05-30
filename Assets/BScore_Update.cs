using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BScore_Update : MonoBehaviour
{


    public Text bscoreLabel1;
    public Text bscoreLabel2;
    public Text bscoreLabel3;
    public Text bscoreLabel4;
    public Text totalbscoreLabel;




    void Update()
    {
        if (totalbscoreLabel != null)
            totalbscoreLabel.text = GameObject.Find("Sheet").GetComponent<Mainscript>().totalbscore.ToString();
        

        if (bscoreLabel1 != null)
            bscoreLabel1.text = GameObject.Find("Sheet").GetComponent<Mainscript>().bscore[0].ToString();
        

        if (bscoreLabel2 != null)
            bscoreLabel2.text = GameObject.Find("Sheet").GetComponent<Mainscript>().bscore[1].ToString();
        

        if (bscoreLabel3 != null)
            bscoreLabel3.text = GameObject.Find("Sheet").GetComponent<Mainscript>().bscore[2].ToString();
        

        if (bscoreLabel4 != null)
            bscoreLabel4.text = GameObject.Find("Sheet").GetComponent<Mainscript>().bscore[3].ToString();
        

    }
}

