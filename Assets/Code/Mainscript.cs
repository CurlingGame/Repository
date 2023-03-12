using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainscript : MonoBehaviour
{
    public GameObject Rstone;
    public GameObject Bstone_1;
    public string turn = "Red";

    void Start()
    {
        Debug.Log("start");
    }

    void Update()
    {
        if (turn == "Red")
        {
            Rstone.SendMessage("Throw");
        }
        else if (turn == "Blue")
        {
            Bstone_1.SendMessage("Throw");
        }
    }
}
