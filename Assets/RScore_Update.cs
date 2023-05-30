using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RScore_Update : MonoBehaviour {

    public Text rscoreLabel1;
    public Text rscoreLabel2;
    public Text rscoreLabel3;
    public Text rscoreLabel4;
    public Text totalrscoreLabel;

    


    void Update()
    {
        if (totalrscoreLabel != null)
            totalrscoreLabel.text = GameObject.Find("Sheet").GetComponent<Mainscript>().totalrscore.ToString();
        

        if (rscoreLabel1 != null)
            rscoreLabel1.text = GameObject.Find("Sheet").GetComponent<Mainscript>().rscore[0].ToString();
        

        if (rscoreLabel2 != null)
            rscoreLabel2.text = GameObject.Find("Sheet").GetComponent<Mainscript>().rscore[1].ToString();
        

        if (rscoreLabel3 != null)
            rscoreLabel3.text = GameObject.Find("Sheet").GetComponent<Mainscript>().rscore[2].ToString();
   

        if (rscoreLabel4 != null)
            rscoreLabel4.text = GameObject.Find("Sheet").GetComponent<Mainscript>().rscore[3].ToString();
        

    }
}
